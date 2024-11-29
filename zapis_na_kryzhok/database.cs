using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zapis_na_kryzhok.database;

namespace zapis_na_kryzhok
{
    internal class Database
    {
        private readonly eremeev_zachet _context;

        public Database(eremeev_zachet context)
        {
            _context = context;
        }
        public async Task SaveTeacher(string name, string surname, string email, string phoneNumber)
        {
            using (var dbContext = new eremeev_zachet())
            {
                var teacher = new Teacher()
                {
                    name = name, surname = surname, email = email, phoneNumber = phoneNumber,
                };

                dbContext.Teacher.Add(teacher);
                await dbContext.SaveChangesAsync();
            }
        }
    } 
}
