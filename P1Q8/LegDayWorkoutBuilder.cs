using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q8
{
    class LegDayWorkoutBuilder : WorkoutBuilder
    {
        protected override void ChooseAerobicsPhase()
        {
            workout.ChooseAerobicsPhase("Eliptical");
        }

        protected override void ChooseMuscleGroup()
        {
            workout.ChooseMuscleGroup("Legs");
        }

        protected override void ChooseStretches()
        {
            workout.ChooseStretches("Flex stretches");
        }

        protected override void ChooseWarmup()
        {
            workout.ChooseWarmup("Light run");
        }
    }
}
