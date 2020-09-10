namespace blzrRakuten.Services 
{
    using System;
    using System.Threading.Tasks;

    public class CounterService : ICounterhHandler
    {
        public event Action onChange;

        public int Counter {get; set;}

        public CounterService() {
            this.Counter = 0;
        }
        
        public async Task Increase(int value)
        {
            this.Counter+=value;
            this.onChange?.Invoke();
        }

        public async Task Decrease(int value){
            this.Counter-=value;
            this.onChange?.Invoke();
        }
    }
}