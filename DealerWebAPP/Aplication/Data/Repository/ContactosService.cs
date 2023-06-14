
using DealerWebApp.DealertWeb.Aplication.Dtos;
using DealerWebApp.DealertWeb.Aplication.Interfaces.Services;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DealerWebApp.DealertWeb.Aplication.Data.Repository
{
    public class ContactosService : IContactosService
    {
        private string conexion = "Data Source=(local); Initial Catalog=DealerDb; Integrated Security=True; MultipleActiveResultSets=True;";

        public async Task<ContactosDto> Add(ContactosDto dto)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            }

            SqlParameter nameComplet = new()
            {
                ParameterName = "@CompleName",
                SqlDbType = SqlDbType.NVarChar,
                Size = 250,
                Value = dto.CompleName
            };
            cmd.Parameters.Add(nameComplet);

            SqlParameter email = new()
            {
                ParameterName = "@Email",
                SqlDbType = SqlDbType.NVarChar,
                Size = 80,
                Value = dto.Email
            };
            cmd.Parameters.Add(email);

            SqlParameter phone = new()
            {
                ParameterName = "@Phones",
                SqlDbType = SqlDbType.NVarChar,
                Size = 80,
                Value = dto.Phones
            };
            cmd.Parameters.Add(phone);

            SqlParameter message = new()
            {
                ParameterName = "Messages",
                SqlDbType = SqlDbType.NVarChar,
                Size = 550,
                Value = dto.Messages
            };
            cmd.Parameters.Add(message);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();

            return dto;
        }

        public async Task Delete(int Id)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            }

            SqlParameter deleteSMS = new()
            {
                ParameterName = "@ContactoId",
                SqlDbType = SqlDbType.Int,
                Value = Id
            };
            cmd.Parameters.Add(deleteSMS);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();

            return;
        }
        public async Task<ContactosDto> Get(int Id)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ContactoId", Id);
            }

            await cn.OpenAsync();
            var reader = cmd.ExecuteReader();

            while (await reader.ReadAsync())
            {
                var contactos = new ContactosDto
                {
                    CompleName = Convert.ToString(reader["CompleName"]),
                    ContactoId = Convert.ToInt32(reader["ContactoId"]),
                    Email = Convert.ToString(reader["Email"]),
                    Phones = Convert.ToString(reader["Phones"]),
                    Messages = Convert.ToString(reader["Messages"])
                };
                return contactos;
            }
            return null;
        }

        public async Task<IEnumerable<ContactosDto>> GetAll()
        {
            List<ContactosDto> listContactosDtos = new();

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
                var contactoDto = new ContactosDto()
                {
                    ContactoId = Convert.ToInt32(0),
                    CompleName = Convert.ToString(1),
                    Email = Convert.ToString(2),
                    Phones = Convert.ToString(3),
                    Messages = Convert.ToString(4),
                };

                listContactosDtos.Add(contactoDto);
            }

            return listContactosDtos;

        }

        public async Task<ContactosDto> Update(int Id, ContactosDto dto)
        {
            using var cn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("", cn);
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
            }

            SqlParameter updateSMS = new()
            {
                ParameterName = "@ContactoId",
                SqlDbType = SqlDbType.Int,
                Value = Id
            };
            cmd.Parameters.Add(updateSMS);

            SqlParameter nameComplet = new()
            {
                ParameterName = "@CompleName",
                SqlDbType = SqlDbType.NVarChar,
                Size = 250,
                Value = dto.CompleName
            };
            cmd.Parameters.Add(nameComplet);

            SqlParameter email = new()
            {
                ParameterName = "@Email",
                SqlDbType = SqlDbType.NVarChar,
                Size = 80,
                Value = dto.Email
            };
            cmd.Parameters.Add(email);

            SqlParameter phone = new()
            {
                ParameterName = "@Phones",
                SqlDbType = SqlDbType.NVarChar,
                Size = 80,
                Value = dto.Phones
            };
            cmd.Parameters.Add(phone);

            SqlParameter message = new()
            {
                ParameterName = "Messages",
                SqlDbType = SqlDbType.NVarChar,
                Size = 550,
                Value = dto.Messages
            };
            cmd.Parameters.Add(message);

            await cn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();

            return dto;
        }

    }

}






