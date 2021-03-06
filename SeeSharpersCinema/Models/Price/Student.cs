using SeeSharpersCinema.Infrastructure;

namespace SeeSharpersCinema.Models.Price
{
    public class Student : ASpecialPrice
    {
        public override string Name { get => "Student Discount"; }
        public bool StudentCard { get; }

        public Student(bool studentCard)
        {
            StudentCard = studentCard;
        }

        private bool validation()
        {
            bool result = false;

            if (StudentCard == true && (DateHelper.GetDay() == "Monday"
                || DateHelper.GetDay() == "Tuesday" || DateHelper.GetDay() == "Wednesday"
                || DateHelper.GetDay() == "Thursday"))
            {
                result = true;
            }

            return result;

        }

        public override double PriceDifference()
        {
            double result = 0;
            if (validation())
            {
                result = -1.5;
            }
            return result;
        }
    }
}
