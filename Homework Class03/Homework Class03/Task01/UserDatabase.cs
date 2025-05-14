namespace Homework_Class03.Task01
{
    public static class UserDatabase
    {
        public static List<User> Users = new List<User>
    {
        new User(1, "Alice", 30),
        new User(2, "Bob", 25),
        new User(3, "Charlie", 30),
        new User(4, "Alice", 22)
    };

        public static List<User> Search(int? id = null, string name = null, int? age = null)
        {
            return Users.Where(user =>
                (!id.HasValue || user.Id == id.Value) &&
                (string.IsNullOrEmpty(name) || user.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) &&
                (!age.HasValue || user.Age == age.Value)
            ).ToList();
        }
    }
}
