using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_State {
    class Program {
        static void Main(string[] args) {
            ModeSwitch modeSwitch = new ModeSwitch();
            modeSwitch.OnSwitch();
            modeSwitch.OnSwitch();
            modeSwitch.OnSwitch();
            modeSwitch.OnSwitch();
        }
    }

    public class ModeSwitch {
        private ModeState modeState = new ModeStateLight();

        public void SetState(ModeState _modeState) {
            modeState = _modeState;
        }

        public void OnSwitch() {
            modeState.Toggle(this);
        }
    }

    public interface ModeState {
        void Toggle(ModeSwitch modeSwitch);
    }

    public class ModeStateLight : ModeState {
        public void Toggle(ModeSwitch modeSwitch) {
            Console.WriteLine("FROM LIGHT TO DARK");
            modeSwitch.SetState(new ModeStateDark());
        }
    }
    public class ModeStateDark : ModeState {
        public void Toggle(ModeSwitch modeSwitch) {
            Console.WriteLine("FROM DARK TO LIGTH");
            modeSwitch.SetState(new ModeStateLight());
        }
    }
}
