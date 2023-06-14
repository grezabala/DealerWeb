using DealerWebApp.DealertWeb.Aplication.Dtos;
using DealerWebApp.DealertWeb.Aplication.Interfaces.Services;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DealerWebApp.DealertWeb.Aplication.Data.Repository
{
    public class CarsServices : ICarsService
    {

        public string conexion = "Data Source=(local); Initial Catalog=DealerDB; Integrated Security=True; MultipleActiveResult=True;";

        public async Task<CarsDto> Add(CarsDto carsDto)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            }

            SqlParameter nameCar = new()
            {
                ParameterName = "@NameCars",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = carsDto.NameCard

            };
            cmd.Parameters[0].Value = nameCar;

            await cn.CloseAsync();
            await cmd.ExecuteScalarAsync();

            return carsDto;
        }

        public async Task Delete(int Id)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            }

            SqlParameter deleteId = new()
            {
                ParameterName = "@CarId",
                SqlDbType = SqlDbType.Int,
                Value = Id
            };
            cmd.Parameters[0].Value = deleteId;
        }

        public async Task<CarsDto> Get(int Id)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CarId", Id);
            }

            await cn.OpenAsync();
            var reader = cmd.ExecuteReader();

            while (await reader.ReadAsync())
            {
                var carsDto = new CarsDto()
                {
                    CardId = Convert.ToInt32(reader["CarId"]),
                    NameCard = Convert.ToString(reader["NameCard"]),

                };

                return carsDto;
            }

            return null;

        }

        public async Task<List<CarsDto>> Get()
        {
            List<CarsDto> listCarsDto = new List<CarsDto>();

            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            }

            await cn.OpenAsync();
            var reader = cmd.ExecuteReader();

            while (await reader.ReadAsync())
            {
                var carsDto = new CarsDto()
                {
                    CardId = Convert.ToInt32(0),
                    NameCard = Convert.ToString(1)

                };

                listCarsDto.Add(carsDto);

            }

            return listCarsDto;
        }

        public async Task<CarsDto> Update(int Id, CarsDto carsDto)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            }

            SqlParameter updateID = new()
            {
                ParameterName = "@CardId",
                SqlDbType = SqlDbType.Int,
                Value = Id
            };
            cmd.Parameters.Add(updateID);

            SqlParameter nameCard = new()
            {
                ParameterName = "@NameCard",
                SqlDbType = SqlDbType.VarChar,
                Size = 50,
                Value = carsDto.NameCard
            };
            cmd.Parameters.Add(nameCard);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();

            return carsDto;
        }
    }
}
