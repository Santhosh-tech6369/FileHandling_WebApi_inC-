using FinalProjectWebApiV0._2.Interface;
using FinalProjectWebApiV0._2.LocalDb;
using FinalProjectWebApiV0._2.Model;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectWebApiV0._2.Repository
{
    public class Repo:IRepo
    {
        private readonly AppDb db;
       
        public Repo(AppDb db)
        {
            this.db = db;  
        }

        public async Task<Student> create (Student st)
        {
            await db.SDetails.AddAsync(st);
            await db.SaveChangesAsync();
            return st;
        }

        public async Task<List<Student>> Read()
        {
            return await db.SDetails.ToListAsync();
        }

        public async Task<Student> Findid(int id)
        {
           return await db.SDetails.FindAsync(id);
        }

        public async Task<bool> Edit(int id,Student st)
        {
            var it = await Findid(id);
            if (it == null)
                return false;
            db.Entry(it).CurrentValues.SetValues(st);
            await db.SaveChangesAsync();
            return true;

        }

        public async Task<bool> Delete(int id)
        {
            var dd = await Findid(id);
            if (dd == null)
                return false;
            db.SDetails.Remove(dd);
            await db.SaveChangesAsync();
            return true;
        }


    }
}
