# TravelBlog API – Hướng dẫn test trên Swagger

Tài liệu này dùng để test API qua Swagger UI thay cho file `TravelBlog.API..http`.

## 1. Khởi chạy & truy cập Swagger

Chạy project (Visual Studio / `dotnet run`). App lắng nghe 2 cổng (xem `Properties/launchSettings.json`):

| Profile | URL | Swagger UI |
|---|---|---|
| http  | `http://localhost:5163`  | **http://localhost:5163/swagger** |
| https | `https://localhost:7187` | **https://localhost:7187/swagger** |

> ⚠️ Lưu ý: cổng **5163 là HTTP**, **7187 là HTTPS**. Đừng vào `https://localhost:5163` — sẽ dính `ERR_SSL_PROTOCOL_ERROR`. Nếu HTTPS báo cert không tin cậy, chạy 1 lần: `dotnet dev-certs https --trust`.

Database `TravelBlogDb` (LocalDB) sẽ được tự động `Migrate()` khi app khởi động (xem `Program.cs`). Database hiện đã được làm mới (drop + update) nên đang trống.

## 2. Tài khoản đăng nhập (JWT)

Endpoint: `POST /api/auth/login`

Body mẫu:
```json
{
  "username": "admin",
  "password": "123456"
}
```

Response trả về `token`. Trên Swagger, bấm nút **Authorize** ở góc phải, dán theo định dạng:

```
Bearer <token>
```

> Hiện tại chỉ endpoint `POST /api/posts` yêu cầu `[Authorize]`. Các endpoint còn lại đều public.

> **Lưu ý:** Swagger UI mặc định chưa cấu hình ô nhập JWT. Nếu chưa có nút Authorize, bạn có thể dùng tab "Try it out" và thêm header thủ công, hoặc test bằng Postman/Thunder Client với header `Authorization: Bearer <token>`.

---

## 3. Categories – `/api/categories`

### 3.1. GET `/api/categories` – Lấy tất cả category
Không cần body. Trả về danh sách category.

### 3.2. GET `/api/categories/{id}` – Lấy theo Id
- Path param: `id` (Guid)
- 404 nếu không tồn tại.

### 3.3. POST `/api/categories` – Tạo category
Body:
```json
{
  "name": "Du lịch biển"
}
```
Các category gợi ý dùng cho seed:
```json
{ "name": "Du lịch biển" }
{ "name": "Du lịch núi" }
{ "name": "Ẩm thực địa phương" }
```
Sau khi tạo, copy `id` trả về để dùng cho phần Posts.

### 3.4. DELETE `/api/categories/{id}` – Xoá category
- Path param: `id` (Guid)

---

## 4. Posts – `/api/posts`

### 4.1. GET `/api/posts` – Danh sách + filter + phân trang

Query params (đều optional):

| Tên | Kiểu | Mặc định | Ghi chú |
|---|---|---|---|
| `filterOn` | string | – | `Location` hoặc `Title` (phân biệt khác giá trị, không phân biệt hoa thường) |
| `filterQuery` | string | – | Chuỗi tìm kiếm (Contains) |
| `pageNumber` | int | `1` | min = 1 |
| `pageSize` | int | `10` | min = 1, max = 100 |

Response:
```json
{
  "pageNumber": 1,
  "pageSize": 10,
  "totalRecords": 20,
  "totalPages": 2,
  "data": [ /* posts */ ]
}
```

Ví dụ test trên Swagger:

- Tất cả: `GET /api/posts`
- Lọc theo địa điểm: `filterOn=Location&filterQuery=DaLat`
- Lọc theo tiêu đề: `filterOn=Title&filterQuery=Ha`
- Phân trang: `pageNumber=2&pageSize=5`
- Kết hợp: `filterOn=Location&filterQuery=DaLat&pageNumber=1&pageSize=2`

> Lưu ý: `filterOn=Category` hiện **không** được hỗ trợ trong code (chỉ có `Location` và `Title`).

### 4.2. GET `/api/posts/{id}` – Chi tiết post
- Path param: `id` (Guid)
- Trả về post kèm `Category`. 404 nếu không tồn tại.

### 4.3. POST `/api/posts` – Tạo post (yêu cầu JWT)

Header: `Authorization: Bearer <token>`

Body (`CreatePostDto`):
```json
{
  "title": "Du lịch Đà Lạt mùa sương",
  "content": "Không khí mát lạnh và lãng mạn",
  "location": "DaLat",
  "imageUrl": "https://example.com/dalat1.jpg",
  "categoryId": "<GUID category>"
}
```

---

## 5. Bộ dữ liệu seed mẫu (20 posts)

Các bước test theo thứ tự:

1. `POST /api/auth/login` → lấy token, bấm **Authorize** trên Swagger.
2. Tạo 3 category bằng `POST /api/categories`, lưu lại 3 Id:
   - `categoryBeachId` ← "Du lịch biển"
   - `categoryMountainId` ← "Du lịch núi"
   - `categoryFoodId` ← "Ẩm thực địa phương"
3. `GET /api/categories` để xác nhận.
4. Tạo 20 post bằng `POST /api/posts` với các body bên dưới (thay `categoryId` cho phù hợp).

| # | Title | Location | CategoryId |
|---|---|---|---|
| 1 | Du lịch Đà Lạt mùa sương | DaLat | mountain |
| 2 | Khám phá Sapa | Sapa | mountain |
| 3 | Biển Nha Trang | NhaTrang | beach |
| 4 | Vịnh Hạ Long | QuangNinh | beach |
| 5 | Huế mộng mơ | Hue | food |
| 6 | Phú Quốc biển xanh | PhuQuoc | beach |
| 7 | Đà Nẵng hiện đại | DaNang | beach |
| 8 | Hà Nội phố cổ | HaNoi | food |
| 9 | TPHCM nhộn nhịp | SaiGon | food |
| 10 | Đà Lạt săn mây | DaLat | mountain |
| 11 | Sapa mùa lạnh | Sapa | mountain |
| 12 | Nha Trang về đêm | NhaTrang | beach |
| 13 | Hạ Long buổi chiều | QuangNinh | beach |
| 14 | Huế và sông Hương | Hue | food |
| 15 | Phú Quốc hoang sơ | PhuQuoc | beach |
| 16 | Đà Nẵng biển Mỹ Khê | DaNang | beach |
| 17 | Hà Nội mùa thu | HaNoi | food |
| 18 | Sài Gòn cafe | SaiGon | food |
| 19 | Đà Lạt hồ Tuyền Lâm | DaLat | mountain |
| 20 | Sapa Fansipan | Sapa | mountain |

Body mẫu (lặp lại cho từng post, đổi nội dung tương ứng):
```json
{
  "title": "Du lịch Đà Lạt mùa sương",
  "content": "Không khí mát lạnh và lãng mạn",
  "location": "DaLat",
  "imageUrl": "https://example.com/dalat1.jpg",
  "categoryId": "<categoryMountainId>"
}
```

## 6. Kịch bản kiểm thử nhanh

| Mục đích | Endpoint |
|---|---|
| Health check | `GET /api/posts` |
| Lọc Location = DaLat | `GET /api/posts?filterOn=Location&filterQuery=DaLat` |
| Lọc Location = Sapa | `GET /api/posts?filterOn=Location&filterQuery=Sapa` |
| Lọc Title chứa "Ha" | `GET /api/posts?filterOn=Title&filterQuery=Ha` |
| Phân trang trang 1, size 5 | `GET /api/posts?pageNumber=1&pageSize=5` |
| Phân trang trang 2, size 5 | `GET /api/posts?pageNumber=2&pageSize=5` |
| Phân trang trang 3, size 5 | `GET /api/posts?pageNumber=3&pageSize=5` |
| Lọc + phân trang | `GET /api/posts?filterOn=Location&filterQuery=DaLat&pageNumber=1&pageSize=2` |
| Get post by Id | `GET /api/posts/{id}` |
| Get category by Id | `GET /api/categories/{id}` |

## 7. Mã lỗi thường gặp

| Code | Khi nào |
|---|---|
| `200 OK` | Thành công |
| `201 Created` | Tạo category/post thành công |
| `401 Unauthorized` | Sai username/password ở `/api/auth/login`, hoặc thiếu token khi `POST /api/posts` |
| `404 Not Found` | Không tìm thấy resource theo `id` |
| `400 Bad Request` | Body sai định dạng |
| `500` | Được middleware `GlobalExceptionHandler` chuyển thành ProblemDetails |
