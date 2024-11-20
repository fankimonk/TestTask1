using DataAccess;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace TestTask1
{
    //Результат вывода хранимой процедуры
    public class StoredProcedureResult
    {
        //Сумма целых чисел
        public long Sum { get; set; }

        //Медиана дробных чисел
        public decimal Median { get; set; }

        private StoredProcedureResult(long sum, decimal median)
        {
            Sum = sum;
            Median = median;
        }

        //Вызов процедуры
        public async static Task<StoredProcedureResult?> ExecProcedure()
        {
            using (var context = new TestTask1DBContext())
            {
                //Задание выходных параметров процедуры
                var sumParam = new SqlParameter("@sum", SqlDbType.BigInt) { Direction = ParameterDirection.Output };
                var medianParam = new SqlParameter("@median", SqlDbType.Decimal) 
                    { Direction = ParameterDirection.Output, Precision = 18, Scale = 8 };

                //Вызов процедуры с параметрами
                await context.Database.ExecuteSqlRawAsync(
                    "EXEC GetSumAndMedian @sum OUT, @median OUT",
                    sumParam,
                    medianParam
                );

                //Возврат объекта результата
                return new StoredProcedureResult((long)sumParam.Value, (decimal)medianParam.Value);
            }
        }
    }
}
