

namespace StatePattern.VendingMachineExample
{
    //State class
    abstract class VendingMachineState
    {
        public abstract void HandleState(VendingMachine context);
    }


}
