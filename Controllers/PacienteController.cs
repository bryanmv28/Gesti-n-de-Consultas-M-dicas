using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using ClinicaMedica.Config;
using ClinicaMedica.Models;

namespace ClinicaMedica.Controllers
{
    public class PacienteController
    {
        private readonly Conexion _conexion;

        public PacienteController()
        {
            _conexion = new Conexion();
        }

        public List<PacienteModel> Listar()
        {
            var lista = new List<PacienteModel>();
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM Pacientes";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new PacienteModel
                            {
                                PacienteId = Convert.ToInt32(dr["paciente_id"]),
                                NombreCompleto = dr["nombre_completo"].ToString(),
                                Edad = Convert.ToInt32(dr["edad"]),
                                Telefono = dr["telefono"]?.ToString(),
                                FechaRegistro = Convert.ToDateTime(dr["fecha_registro"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar pacientes: " + ex.Message);
            }
            return lista;
        }

        public string Insertar(PacienteModel paciente)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"INSERT INTO Pacientes (nombre_completo, edad, telefono)
                                    VALUES (@nombre, @edad, @telefono)";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", paciente.NombreCompleto);
                        cmd.Parameters.AddWithValue("@edad", paciente.Edad);
                        cmd.Parameters.AddWithValue("@telefono", (object)paciente.Telefono ?? DBNull.Value);
                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0 ? "ok" : "error";
                    }
                }
            }
            catch (Exception ex)
            {
                return "error: " + ex.Message;
            }
        }

        public string Actualizar(PacienteModel paciente)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"UPDATE Pacientes SET 
                                    nombre_completo = @nombre,
                                    edad = @edad,
                                    telefono = @telefono
                                    WHERE paciente_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", paciente.NombreCompleto);
                        cmd.Parameters.AddWithValue("@edad", paciente.Edad);
                        cmd.Parameters.AddWithValue("@telefono", (object)paciente.Telefono ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@id", paciente.PacienteId);
                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0 ? "ok" : "error";
                    }
                }
            }
            catch (Exception ex)
            {
                return "error: " + ex.Message;
            }
        }

        public string Eliminar(int pacienteId)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "DELETE FROM Pacientes WHERE paciente_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", pacienteId);
                        int filas = cmd.ExecuteNonQuery();
                        return filas > 0 ? "ok" : "error";
                    }
                }
            }
            catch (Exception ex)
            {
                return "error: " + ex.Message;
            }
        }
    }
}