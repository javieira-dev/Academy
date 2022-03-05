
namespace IntroducaoPolimorfismo.Entities
{
    class AutosourcedEmployee : Employee
    {
        public double AditionalCharge { get; set; }

        public AutosourcedEmployee()
        {

        }

        public AutosourcedEmployee(string name, int hours, double valuePerHour, double aditionalCharge): base(name, hours, valuePerHour)
        {
            AditionalCharge = aditionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AditionalCharge;
        }
    }
}
