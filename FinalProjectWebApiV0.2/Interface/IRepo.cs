using FinalProjectWebApiV0._2.Model;

namespace FinalProjectWebApiV0._2.Interface
{
    public interface IRepo
    {
        Task<Student> create(Student st);
        Task<List<Student>> Read();
        Task<bool> Edit(int id, Student st);
        Task<bool> Delete(int id);
        Task<Student> Findid(int id);
    }
}
