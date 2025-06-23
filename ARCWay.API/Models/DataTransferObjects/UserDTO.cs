namespace ARCWay.API.Models.DataTransferObjects;

public class UserDTO
{
    public string Id { get; set; }
    public string Name { get; set; } = string.Empty;

    // Optional: include only what you want to expose via API
    public string? Email { get; set; }

    // Example: omit password, tokens, etc.
}