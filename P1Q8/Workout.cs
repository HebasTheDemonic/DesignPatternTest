using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Q8
{
    public class Workout
    {
        private string warmup;
        private string aerobics;
        private string muscleGroup;
        private string stretches;
        public Workout()
        {
            warmup = null;
            aerobics = null;
            muscleGroup = null;
            stretches = null;
        }

        public void ChooseWarmup(string warmup)
        {
            if (this.warmup == null)
            {
                this.warmup = warmup;
            }
            else
            {
                throw new InvalidOperationException("Warmup is already selected for this workout");
            }
        }

        public void ChooseAerobicsPhase(string aerobics)
        {
            if (this.aerobics == null)
            {
                this.aerobics = aerobics;
            }
            else
            {
                throw new InvalidOperationException("Aerobics exercise already selected for this workout");
            }
        }

        public void ChooseMuscleGroup(string group)
        {
            if (this.muscleGroup == null)
            {
                this.muscleGroup = group;
            }
            else
            {
                throw new InvalidOperationException("Muscle group already selected for this workout");
            }
        }

        public void ChooseStretches(string stretches)
        {
            if (this.stretches == null)
            {
                this.stretches = stretches;
            }
            else
            {
                throw new InvalidOperationException("Stretches already selected for this workout");
            }
        }
    }
}
