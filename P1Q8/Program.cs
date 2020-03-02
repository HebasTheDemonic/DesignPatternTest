using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<WorkoutBuilder> workoutPlan = new List<WorkoutBuilder>();
            workoutPlan.Add(new LegDayWorkoutBuilder());

        }
    }
}
