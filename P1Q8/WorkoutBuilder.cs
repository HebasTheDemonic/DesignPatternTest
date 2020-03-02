using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q8
{
    public abstract class WorkoutBuilder
    {
        protected Workout workout;

        public Workout GetWorkout()
        {
            return workout;
        }

        public void BuildWorkout()
        {
            this.workout = new Workout();

        }

        protected abstract void ChooseWarmup();
        protected abstract void ChooseAerobicsPhase();
        protected abstract void ChooseMuscleGroup();
        protected abstract void ChooseStretches();
    }
}
