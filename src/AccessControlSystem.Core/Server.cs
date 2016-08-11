namespace AccessControlSystem.Core
{
    public class Server
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public ServerType ServerType { get; set; }
        public AccessPolicy Policy { get; set; }        
    }
}