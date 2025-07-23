using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using ClinicaMedica.Config;
using ClinicaMedica.Models;

namespace ClinicaMedica.Controllers
{
    public class CitaController
    {
        private readonly Conexion _conexion;

        public CitaController()
        {
            _conexion = new Conexion();
        }

        public List<CitaModel> Listar()
        {
            var lista = new List<CitaModel>();
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "SELECT * FROM Citas";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CitaModel
                            {
                                CitaId = Convert.ToInt32(dr["cita_id"]),
                                PacienteId = Convert.ToInt32(dr["paciente_id"]),
                                MedicoId = Convert.ToInt32(dr["medico_id"]),
                                FechaCita = Convert.ToDateTime(dr["fecha_cita"]),
                                Diagnostico = dr["diagnostico"]?.ToString(),
                                Estado = dr["estado"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar citas: " + ex.Message);
            }
            return lista;
        }

        public string Insertar(CitaModel cita)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"INSERT INTO Citas (paciente_id, medico_id, fecha_cita, diagnostico, estado)
                                    VALUES (@pacienteId, @medicoId, @fechaCita, @diagnostico, @estado)";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@pacienteId", cita.PacienteId);
                        cmd.Parameters.AddWithValue("@medicoId", cita.MedicoId);
                        cmd.Parameters.AddWithValue("@fechaCita", cita.FechaCita);
                        cmd.Parameters.AddWithValue("@diagnostico", (object)cita.Diagnostico ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@estado", cita.Estado);
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

        public string Actualizar(CitaModel cita)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = @"UPDATE Citas SET 
                                    paciente_id = @pacienteId,
                                    medico_id = @medicoId,
                                    fecha_cita = @fechaCita,
                                    diagnostico = @diagnostico,
                                    estado = @estado
                                    WHERE cita_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@pacienteId", cita.PacienteId);
                        cmd.Parameters.AddWithValue("@medicoId", cita.MedicoId);
                        cmd.Parameters.AddWithValue("@fechaCita", cita.FechaCita);
                        cmd.Parameters.AddWithValue("@diagnostico", (object)cita.Diagnostico ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@estado", cita.Estado);
                        cmd.Parameters.AddWithValue("@id", cita.CitaId);
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

        public string Eliminar(int citaId)
        {
            try
            {
                using (MySqlConnection cn = (MySqlConnection)_conexion.AbrirConexion())
                {
                    string query = "DELETE FROM Citas WHERE cita_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", citaId);
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
