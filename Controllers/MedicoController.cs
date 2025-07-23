using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using ClinicaMedica.Config;
using ClinicaMedica.Models;

namespace ClinicaMedica.Controllers
{
    public class MedicoController
    {
        private readonly Conexion _conexion;

        public MedicoController()
        {
            _conexion = new Conexion();
        }

        public List<MedicoModel> Listar()
        {
            var lista = new List<MedicoModel>();
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM Medicos";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new MedicoModel
                            {
                                MedicoId = Convert.ToInt32(dr["medico_id"]),
                                NombreCompleto = dr["nombre_completo"].ToString(),
                                Especialidad = dr["especialidad"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar médicos: " + ex.Message);
            }
            return lista;
        }

        public string Insertar(MedicoModel medico)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"INSERT INTO Medicos (nombre_completo, especialidad)
                                    VALUES (@nombre, @especialidad)";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", medico.NombreCompleto);
                        cmd.Parameters.AddWithValue("@especialidad", medico.Especialidad);
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

        public string Actualizar(MedicoModel medico)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"UPDATE Medicos SET 
                                    nombre_completo = @nombre,
                                    especialidad = @especialidad
                                    WHERE medico_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", medico.NombreCompleto);
                        cmd.Parameters.AddWithValue("@especialidad", medico.Especialidad);
                        cmd.Parameters.AddWithValue("@id", medico.MedicoId);
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

        public string Eliminar(int medicoId)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "DELETE FROM Medicos WHERE medico_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", medicoId);
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