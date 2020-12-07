using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics.Intermediate.Classes {
    class Hero {

        string heroName { get; set; }
        string heroClass { get; set; }
        int heroLevel = 1;
        int heroWealth = 25;

        public void HeroLevelUp() {
            this.heroLevel++;
        }

    }

}
