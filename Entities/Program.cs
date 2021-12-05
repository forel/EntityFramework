using Npgsql;
using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            DataOperations.RemoveAllData();
            DataOperations.LoadData();
        }
    }
}
