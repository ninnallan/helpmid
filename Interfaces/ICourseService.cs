namespace Midterm.Interfaces
{
    public interface ICourseService
    {
        public void AddCourse(string course); // ეს მეთოდიც დავამატე დასატესტად (თუმცა სამწუხაროდ საერთოდ არ გაეშვა პროექტი და ვერ დავტესტე :) იმედი მაქვს გაითვალისწინებთ)
        public List<string> GetCourses(int pageIndex, int pageSize);
    }
}
