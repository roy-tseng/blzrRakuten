namespace blzrRakuten.Services 
{
    using System;
    using System.Threading.Tasks;

    public interface ICounterhHandler{

        Task Increase(int value);

        Task Decrease(int value);
    }
}