using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared
{
    public class Validator
    {
        int MaxManagers = 3;
        int MaxCashiers = 4;
        int MaxStaff = 10;

        int CurrentManagers = 0;
        int CurrentCashiers = 0;
        int CurrentStaff = 0;

        bool StaPass = false;

        bool ManPass = false;
        bool CasPass = false;

        public bool CheckEmployeeLimits(List<Model.Employee> employees, Model.Employee incoming)
        {
            foreach (var Emp in employees) {
                switch (Emp.EmployeeType)
                {
                    case Enums.EmployeeType.Manager:
                        CurrentManagers++;
                        break;
                    case Enums.EmployeeType.Staff:
                        CurrentStaff++;
                        break;
                    case Enums.EmployeeType.Cashier:
                        CurrentCashiers++;
                        break;
                    default:
                        break;
                }

            }
            switch (incoming.EmployeeType)
            {
                case Enums.EmployeeType.Manager:
                    CurrentManagers++;
                    break;
                case Enums.EmployeeType.Staff:
                    CurrentStaff++;
                    break;
                case Enums.EmployeeType.Cashier:
                    CurrentCashiers++;
                    break;
                default:
                    break;
            }
            if (CurrentManagers<=MaxManagers) {ManPass = true; }
            if (CurrentCashiers<=MaxCashiers) { CasPass = true; }
            if (CurrentStaff<=MaxStaff) { StaPass = true; }
            return ManPass && CasPass && StaPass;
        }



    }
}
