using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WindowsFormsAppTest;

public class UserService
{
    private readonly string _filePath = "users.json";

    public List<User> LoadUsers()
    {
        if (!File.Exists(_filePath))
            return new List<User>();

        string json = File.ReadAllText(_filePath);
        return JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
    }

    private void SaveUsers(List<User> users)
    {
        string json = JsonConvert.SerializeObject(users, Formatting.Indented);
        File.WriteAllText(_filePath, json);
    }

    public string Register(string username, string password, string fullName)
    {
        if (string.IsNullOrWhiteSpace(username))
            return "Tên đăng nhập không được để trống.";
        if (string.IsNullOrWhiteSpace(password))
            return "Mật khẩu không được để trống.";
        if (password.Length < 4)
            return "Mật khẩu phải có ít nhất 4 ký tự.";

        var users = LoadUsers();

        if (users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            return "Tên đăng nhập đã tồn tại.";

        users.Add(new User
        {
            Username = username,
            Password = password,
            FullName = fullName
        });

        SaveUsers(users);
        return null; // thành công
    }

    // Đăng nhập — trả về User nếu đúng, null nếu sai
    public User Login(string username, string password)
    {
        var users = LoadUsers();
        return users.FirstOrDefault(u =>
            u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
            && u.Password == password);
    }
}