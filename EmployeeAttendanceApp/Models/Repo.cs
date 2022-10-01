using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace EmployeeAttendanceApp.Models
{
    public class Repo
    {
        ObservableCollection<Employee> employees;
        ObservableCollection<Attendance> attendances;
        public Repo()
        {
            this.employees = new ObservableCollection<Employee>()
            {
                new Employee { Id=1, Name="A Page", Department="HR", Picture="Assets/e01.jpg"},
                new Employee { Id=2, Name="J Blair", Department="HR", Picture="Assets/e02.jpg"},
                new Employee { Id=3, Name="B Lynch", Department="Admin", Picture="Assets/e03.jpg"},
                new Employee { Id=4, Name="J Rose", Department="Admin", Picture="Assets/e04.jpg"},
                new Employee { Id=5, Name="C Jorge", Department="Accounts", Picture="Assets/e05.jpg"},
                new Employee { Id=6, Name="K Moore", Department="Accounts", Picture="Assets/e06.jpg"},
                new Employee { Id=7, Name="G Jossep", Department="Marketing", Picture="Assets/e07.jpg"},
                new Employee { Id=8, Name="M Jack", Department="Marketing", Picture="Assets/e08.jpg"},
                new Employee { Id=9, Name="G Gough", Department="Marketing", Picture="Assets/e09.jpg"},
                new Employee { Id=10, Name="R Ponting", Department="Customar care exicutive", Picture="Assets/e10.jpg"}
            };
            this.attendances = new ObservableCollection<Attendance>() {
                new Attendance { Date=new DateTime(2022, 5, 1), EmployeeId=1, InTime=new DateTime(2022, 5, 1, 9, 1, 3), OutTime=new DateTime(2022, 5, 1, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 2), EmployeeId=1, InTime=new DateTime(2022, 5, 2, 8, 58, 12), OutTime=new DateTime(2022, 5, 2, 16, 55, 6)},
                new Attendance { Date=new DateTime(2022, 5, 3), EmployeeId=1, InTime=new DateTime(2022, 5, 3, 9, 3, 0), OutTime=new DateTime(2022, 5, 3, 17, 17, 11)},
                new Attendance { Date=new DateTime(2022, 5, 4), EmployeeId=1, InTime=new DateTime(2022, 5, 4, 9, 12, 4), OutTime=new DateTime(2022, 5, 4, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 1), EmployeeId=2, InTime=new DateTime(2022, 5, 1, 9, 1, 3), OutTime=new DateTime(2022, 5, 1, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 2), EmployeeId=2, InTime=new DateTime(2022, 5, 2, 8, 58, 12), OutTime=new DateTime(2022, 5, 2, 16, 55, 6)},
                new Attendance { Date=new DateTime(2022, 5, 3), EmployeeId=2, InTime=new DateTime(2022, 5, 3, 9, 3, 0), OutTime=new DateTime(2022, 5, 3, 17, 17, 11)},
                new Attendance { Date=new DateTime(2022, 5, 4), EmployeeId=2, InTime=new DateTime(2022, 5, 4, 9, 12, 4), OutTime=new DateTime(2022, 5, 4, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 1), EmployeeId=3, InTime=new DateTime(2022, 5, 1, 9, 1, 3), OutTime=new DateTime(2022, 5, 1, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 2), EmployeeId=3, InTime=new DateTime(2022, 5, 2, 8, 58, 12), OutTime=new DateTime(2022, 5, 2, 16, 55, 6)},
                new Attendance { Date=new DateTime(2022, 5, 3), EmployeeId=3, InTime=new DateTime(2022, 5, 3, 9, 3, 0), OutTime=new DateTime(2022, 5, 3, 17, 17, 11)},
                new Attendance { Date=new DateTime(2022, 5, 4), EmployeeId=3, InTime=new DateTime(2022, 5, 4, 9, 12, 4), OutTime=new DateTime(2022, 5, 4, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 1), EmployeeId=4, InTime=new DateTime(2022, 5, 1, 9, 1, 3), OutTime=new DateTime(2022, 5, 1, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 2), EmployeeId=4, InTime=new DateTime(2022, 5, 2, 8, 58, 12), OutTime=new DateTime(2022, 5, 2, 16, 55, 6)},
                new Attendance { Date=new DateTime(2022, 5, 3), EmployeeId=4, InTime=new DateTime(2022, 5, 3, 9, 3, 0), OutTime=new DateTime(2022, 5, 3, 17, 17, 11)},
                new Attendance { Date=new DateTime(2022, 5, 4), EmployeeId=4, InTime=new DateTime(2022, 5, 4, 9, 12, 4), OutTime=new DateTime(2022, 5, 4, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 1), EmployeeId=5, InTime=new DateTime(2022, 5, 1, 9, 1, 3), OutTime=new DateTime(2022, 5, 1, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 2), EmployeeId=5, InTime=new DateTime(2022, 5, 2, 8, 58, 12), OutTime=new DateTime(2022, 5, 2, 16, 55, 6)},
                new Attendance { Date=new DateTime(2022, 5, 3), EmployeeId=5, InTime=new DateTime(2022, 5, 3, 9, 3, 0), OutTime=new DateTime(2022, 5, 3, 17, 17, 11)},
                new Attendance { Date=new DateTime(2022, 5, 4), EmployeeId=5, InTime=new DateTime(2022, 5, 4, 9, 12, 4), OutTime=new DateTime(2022, 5, 4, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 1), EmployeeId=6, InTime=new DateTime(2022, 5, 1, 9, 1, 3), OutTime=new DateTime(2022, 5, 1, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 2), EmployeeId=6, InTime=new DateTime(2022, 5, 2, 8, 58, 12), OutTime=new DateTime(2022, 5, 2, 16, 55, 6)},
                new Attendance { Date=new DateTime(2022, 5, 3), EmployeeId=6, InTime=new DateTime(2022, 5, 3, 9, 3, 0), OutTime=new DateTime(2022, 5, 3, 17, 17, 11)},
                new Attendance { Date=new DateTime(2022, 5, 4), EmployeeId=6, InTime=new DateTime(2022, 5, 4, 9, 12, 4), OutTime=new DateTime(2022, 5, 4, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 1), EmployeeId=7, InTime=new DateTime(2022, 5, 1, 9, 1, 3), OutTime=new DateTime(2022, 5, 1, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 2), EmployeeId=7, InTime=new DateTime(2022, 5, 2, 8, 58, 12), OutTime=new DateTime(2022, 5, 2, 16, 55, 6)},
                new Attendance { Date=new DateTime(2022, 5, 3), EmployeeId=7, InTime=new DateTime(2022, 5, 3, 9, 3, 0), OutTime=new DateTime(2022, 5, 3, 17, 17, 11)},
                new Attendance { Date=new DateTime(2022, 5, 4), EmployeeId=7, InTime=new DateTime(2022, 5, 4, 9, 12, 4), OutTime=new DateTime(2022, 5, 4, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 1), EmployeeId=8, InTime=new DateTime(2022, 5, 1, 9, 1, 3), OutTime=new DateTime(2022, 5, 1, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 2), EmployeeId=8, InTime=new DateTime(2022, 5, 2, 8, 58, 12), OutTime=new DateTime(2022, 5, 2, 16, 55, 6)},
                new Attendance { Date=new DateTime(2022, 5, 3), EmployeeId=8, InTime=new DateTime(2022, 5, 3, 9, 3, 0), OutTime=new DateTime(2022, 5, 3, 17, 17, 11)},
                new Attendance { Date=new DateTime(2022, 5, 4), EmployeeId=8, InTime=new DateTime(2022, 5, 4, 9, 12, 4), OutTime=new DateTime(2022, 5, 4, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 1), EmployeeId=9, InTime=new DateTime(2022, 5, 1, 9, 1, 3), OutTime=new DateTime(2022, 5, 1, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 2), EmployeeId=9, InTime=new DateTime(2022, 5, 2, 8, 58, 12), OutTime=new DateTime(2022, 5, 2, 16, 55, 6)},
                new Attendance { Date=new DateTime(2022, 5, 3), EmployeeId=9, InTime=new DateTime(2022, 5, 3, 9, 3, 0), OutTime=new DateTime(2022, 5, 3, 17, 17, 11)},
                new Attendance { Date=new DateTime(2022, 5, 4), EmployeeId=9, InTime=new DateTime(2022, 5, 4, 9, 12, 4), OutTime=new DateTime(2022, 5, 4, 17, 2, 11)},
                new Attendance { Date=new DateTime(2022, 5, 1), EmployeeId=10, InTime=new DateTime(2022, 5, 1, 9, 2, 5), OutTime=new DateTime(2022, 5, 1, 17, 2, 44)},
                new Attendance { Date=new DateTime(2022, 5, 2), EmployeeId=10, InTime=new DateTime(2022, 5, 2, 8, 58, 58), OutTime=new DateTime(2022, 5, 2, 16, 55, 6)},
                new Attendance { Date=new DateTime(2022, 5, 3), EmployeeId=10, InTime=new DateTime(2022, 5, 3, 9, 23, 20), OutTime=new DateTime(2022, 5, 3, 17, 17, 17)},
                new Attendance { Date=new DateTime(2022, 5, 4), EmployeeId=10, InTime=new DateTime(2022, 5, 4, 9, 12, 45), OutTime=new DateTime(2022, 5, 4, 17, 3, 15)}


            };
        }
        public ObservableCollection<Employee> Employees() => this.employees;
        public IEnumerable<Attendance> Attendances( int id) => this.attendances.Where(x=> x.EmployeeId==id).ToList();
    }
}
