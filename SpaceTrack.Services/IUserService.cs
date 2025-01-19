using SpaceTrack.DAL.Model;
namespace SpaceTrack.Services
{
    public interface IUserService
    {
        // Register a new user
        Task<User> Register(User user);

        // User login
        Task<User> Login(string name, string password);

        // Get all users
        Task<List<User>> GetAllUsers();

        // Add a new user
        Task<User> AddUser(User user);

        // Update an existing user
        Task<User> UpdateUserAsync(User user);

        // Delete a user
        Task DeleteUser(string userId);
        Task<bool> ForgotPasswordAsync(string email);
        Task<bool> ResetPasswordAsync(string token, string newPassword);
        Task<User> GetUserByEmailAsync(string email);
        Task SendMessage(ContactMessage message);
        Task<List<ContactMessage>> GetAllMessages(); // For admin to retrieve all messages

    }

}
