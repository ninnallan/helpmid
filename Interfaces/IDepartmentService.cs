namespace Midterm.Interfaces
{
    public interface IDepartmentService
    {
        public List<string> AddDepartmentsToCache();
        public List<string> GetDepartmentsFromCache();
    }
}
