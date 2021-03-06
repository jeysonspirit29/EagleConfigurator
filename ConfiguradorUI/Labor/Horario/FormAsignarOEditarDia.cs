﻿using ConfigBusinessEntity;
using ConfigBusinessLogic.Labor;
using ConfigBusinessLogic.Utiles;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperControl;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguradorUI.Labor.Horario
{
    public partial class FormAsignarOEditarDia : MetroForm
    {
        enum TipoOperacion
        {
            EditarHoratioDtl,
            AsignarHorarioDtl,
            CrearHorarioYAsignarHorarioDtl
        };

        long _idEmpleado;
        long _idHorario;
        LABt04_horario_emp_dtl _horarioDtl;
        DateTime _fechaAAsignar;

        TipoOperacion _TipoOperacion;
        public bool _seOpero = false;

        public FormAsignarOEditarDia(LABt04_horario_emp_dtl horarioDtl)
        {
            InitializeComponent();

            _horarioDtl = horarioDtl;
            _TipoOperacion = TipoOperacion.EditarHoratioDtl;
        }

        public FormAsignarOEditarDia(long idHorario, DateTime fechaAAsignar)
        {
            InitializeComponent();

            _idHorario = idHorario;
            _fechaAAsignar = fechaAAsignar;
            _TipoOperacion = TipoOperacion.AsignarHorarioDtl;
        }

        public FormAsignarOEditarDia(DateTime fechaAAsignar, long idEmpleado)
        {
            InitializeComponent();

            _idEmpleado = idEmpleado;
            _fechaAAsignar = fechaAAsignar;
            _TipoOperacion = TipoOperacion.CrearHorarioYAsignarHorarioDtl;

        }

        private void AddHandlers()
        {
            //Form
            KeyPreview = true;
            KeyDown += ControlHelper.FormCloseShiftEsc_KeyDown;

            dtpHoraInicioBreak.KeyPress += DtpBreak_KeyPress;
            dtpHoraFinBreak.KeyPress += DtpBreak_KeyPress;

            dtpHoraInicioBreak.MouseDown += DtpBreak_MouseDown;
            dtpHoraFinBreak.MouseDown += DtpBreak_MouseDown;
        }

        private void ConfigurarControles()
        {
           // DateFormat
            ControlHelper.FormatDatePicker(dtpHoraInicioLabor, customFormat: DateFormat.TimeDefault);
            ControlHelper.FormatDatePicker(dtpHoraFinLabor, customFormat: DateFormat.TimeDefault);
            ControlHelper.FormatDatePicker(dtpHoraInicioBreak, customFormat: DateFormat.Blank);
            ControlHelper.FormatDatePicker(dtpHoraFinBreak, customFormat: DateFormat.Blank);
            ControlHelper.FormatDatePicker(dtpTiempoTolerancia, customFormat: DateFormat.TimeDefault);

            if (_TipoOperacion == TipoOperacion.EditarHoratioDtl)
            {
                dtpHoraInicioBreak.Value = Convert.ToDateTime(_horarioDtl.hora_inicio.ToString());
                dtpHoraFinBreak.Value = Convert.ToDateTime(_horarioDtl.hora_inicio.ToString());
            }
            else
            {
                dtpHoraInicioLabor.Value = Convert.ToDateTime(new TimeSpan(8, 0, 0).ToString());
                dtpHoraFinLabor.Value = Convert.ToDateTime(new TimeSpan(17, 0, 0).ToString());

                dtpHoraInicioBreak.Value = Convert.ToDateTime(new TimeSpan(12, 0, 0).ToString());
                dtpHoraFinBreak.Value = Convert.ToDateTime(new TimeSpan(13, 0, 0).ToString());

                dtpTiempoTolerancia.Value = Convert.ToDateTime(new TimeSpan(0, 0, 0).ToString());
            }
        }

        private bool ExisteDiaEnHorario()
        {
            return _horarioDtl != null && _horarioDtl.id_horario_emp_dtl > 0;
        }

        private DateTimePicker[] GetDtps()
        {
            return new[]
                    {
                        dtpHoraInicioLabor,
                        dtpHoraFinLabor,
                        dtpHoraInicioBreak,
                        dtpHoraFinBreak,
                        dtpTiempoTolerancia
                    };
        }

        private LABt04_horario_emp_dtl GetHorarioDtl()
        {
            var horarioDtl = new LABt04_horario_emp_dtl();

            try
            {
                if (_TipoOperacion == TipoOperacion.EditarHoratioDtl)
                {
                    horarioDtl.fecha_labor = _horarioDtl.fecha_labor;
                    horarioDtl.id_horario_emp = _horarioDtl.id_horario_emp;
                    horarioDtl.id_horario_emp_dtl = _horarioDtl.id_horario_emp_dtl;
                }
                else if (_TipoOperacion == TipoOperacion.AsignarHorarioDtl)
                {
                    horarioDtl.fecha_labor = _fechaAAsignar;
                    horarioDtl.id_horario_emp = _idHorario;
                }
                else if (_TipoOperacion == TipoOperacion.CrearHorarioYAsignarHorarioDtl)
                {
                    horarioDtl.fecha_labor = _fechaAAsignar;
                }

                horarioDtl.hora_inicio = GetHoraYMinutos(dtpHoraInicioLabor.Value.TimeOfDay);
                horarioDtl.hora_fin = GetHoraYMinutos(dtpHoraFinLabor.Value.TimeOfDay);
                horarioDtl.tiempo_tolerancia = GetHoraYMinutos(dtpTiempoTolerancia.Value.TimeOfDay);

                if (dtpHoraInicioBreak.CustomFormat != " " && dtpHoraFinBreak.CustomFormat != " ")
                {
                    horarioDtl.hora_inicio_break = GetHoraYMinutos(dtpHoraInicioBreak.Value.TimeOfDay);
                    horarioDtl.hora_fin_break = GetHoraYMinutos(dtpHoraFinBreak.Value.TimeOfDay);
                }

            }
            catch (Exception e)
            {
                Msg.Ok_Err("No se pudo obtener el día de horario correctamente. Excepción: " + e.Message);
            }
            return horarioDtl;
        }

        private void SetHorarioDtl()
        {
            try
            {
                if (_TipoOperacion == TipoOperacion.EditarHoratioDtl)
                {
                    lblNombreForm.Text = "Editar: " + _horarioDtl.fecha_labor.ToLongDateString();

                    dtpHoraInicioLabor.Value = Convert.ToDateTime(_horarioDtl.hora_inicio.ToString());
                    dtpHoraFinLabor.Value = Convert.ToDateTime(_horarioDtl.hora_fin.ToString());

                    if (_horarioDtl.hora_inicio_break != null)
                    {
                        dtpHoraInicioBreak.Value = Convert.ToDateTime(_horarioDtl.hora_inicio_break.ToString());
                        ControlHelper.FormatDatePicker(dtpHoraInicioBreak, customFormat: DateFormat.TimeDefault);
                    }

                    if (_horarioDtl.hora_fin_break != null)
                    {
                        dtpHoraFinBreak.Value = Convert.ToDateTime(_horarioDtl.hora_fin_break.ToString());
                        ControlHelper.FormatDatePicker(dtpHoraFinBreak, customFormat: DateFormat.TimeDefault);
                    }

                    dtpTiempoTolerancia.Value = Convert.ToDateTime(_horarioDtl.tiempo_tolerancia.ToString());
                    chkModificarEnTodosLosMismosDias.Text = "Guardar las mismas horas para todos los " + _horarioDtl.fecha_labor.ToString("dddd");
                }
                else
                {
                    lblNombreForm.Text = "Asignar: " + _fechaAAsignar.ToLongDateString();
                    chkModificarEnTodosLosMismosDias.Visible = false;
                }
            }
            catch (Exception e)
            {
                Msg.Ok_Err("No se pudo mostrar el día de horario correctamente. Excepción: " + e.Message);
            }
        }

        private TimeSpan GetHoraYMinutos(TimeSpan hora)
        {
            return new TimeSpan(hora.Hours, hora.Minutes, 0);
        }

        private void ValidarHoraInicioLabor(DateTimePicker dtp)
        {
            var nameDtp = dtp.Name;

            TimeSpan horaInicio = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaFin = GetHoraYMinutos(dtpHoraFinLabor.Value.TimeOfDay);

            errorProv.SetError(dtpHoraInicioLabor, null);

            if (dtpHoraInicioBreak.CustomFormat != " ")
            {
                var horaInicioBrk = GetHoraYMinutos(dtpHoraInicioBreak.Value.TimeOfDay);
                if (horaInicio > horaInicioBrk)
                {
                    errorProv.SetError(dtpHoraInicioLabor, "La \"Hora inicio\" no puede ser mayor que la hora \"Inicio break\".");
                }
            }
            else if (horaInicio > horaFin)
            {
                errorProv.SetError(dtpHoraInicioLabor, "La \"Hora inicio\" no puede ser mayor que la \"Hora fin\".");
            }
        }

        private void ValidarHoraFinLabor(DateTimePicker dtp)
        {
            TimeSpan horaFin = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaInicio = GetHoraYMinutos(dtpHoraInicioLabor.Value.TimeOfDay);

            errorProv.SetError(dtpHoraFinLabor, null);

            if (dtpHoraFinBreak.CustomFormat != " ")
            {
                var horaFinBrk = GetHoraYMinutos(dtpHoraFinBreak.Value.TimeOfDay);
                if (horaFin < horaFinBrk)
                {
                    errorProv.SetError(dtpHoraFinLabor, "La \"Hora fin\" no puede ser menor que la hora \"Fin break\".");
                }
            }
            else if (horaFin < horaInicio)
            {
                errorProv.SetError(dtpHoraFinLabor, "La \"Hora fin\" no puede ser menor que la \"Hora inicio\".");
            }
        }

        private void ValidarHoraInicioBreak(DateTimePicker dtp)
        {
            TimeSpan horaInicioBreak = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaInicioLabor = GetHoraYMinutos(dtpHoraInicioLabor.Value.TimeOfDay);
            TimeSpan horaFinBreak = GetHoraYMinutos(dtpHoraFinBreak.Value.TimeOfDay);

            errorProv.SetError(dtpHoraInicioBreak, null);

            if (horaInicioBreak < horaInicioLabor)
            {
                errorProv.SetError(dtpHoraInicioBreak, "La hora \"Inicio break\" no puede ser menor que la \"Hora inicio\".");
            }
            else if (horaInicioBreak > horaFinBreak)
            {
                errorProv.SetError(dtpHoraInicioBreak, "La hora \"Inicio break\" no puede ser mayor que la hora \"Fin break\".");
            }
        }

        private void ValidarHoraFinBreak(DateTimePicker dtp)
        {
            TimeSpan horaFinBreak = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaFinLabor = GetHoraYMinutos(dtpHoraFinLabor.Value.TimeOfDay);
            TimeSpan horaInicioBreak = GetHoraYMinutos(dtpHoraInicioBreak.Value.TimeOfDay);

            errorProv.SetError(dtpHoraFinBreak, null);

            if (horaFinBreak > horaFinLabor)
            {
                errorProv.SetError(dtpHoraFinBreak, "La hora \"Fin break\" no puede ser mayor que la \"Hora Fin\".");
            }
            else if (horaFinBreak < horaInicioBreak)
            {
                errorProv.SetError(dtpHoraFinBreak, "La hora \"Fin break\" no puede ser menor que la hora \"Inicio break\".");
            }
        }

        private void ValidarTiempoTolerancia(DateTimePicker dtp)
        {
            TimeSpan tiempoTolerancia = GetHoraYMinutos(dtp.Value.TimeOfDay);
            TimeSpan horaInicioLabor = GetHoraYMinutos(dtpHoraInicioLabor.Value.TimeOfDay);
            TimeSpan horaFinLabor = GetHoraYMinutos(dtpHoraFinLabor.Value.TimeOfDay);
            TimeSpan maxTolerancia = horaFinLabor - horaInicioLabor;

            errorProv.SetError(dtpTiempoTolerancia, null);

            if (tiempoTolerancia > maxTolerancia)
            {
                errorProv.SetError(dtpTiempoTolerancia, $"El tiempo de \"Tolerancia\" sobrepasa al rango de horas del día ({maxTolerancia.ToString()} horas).");
            }
        }

        private void dtpHoraInicioLabor_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            ValidarHoraInicioLabor(dtp);
        }

        private void dtpHoraFinLabor_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            ValidarHoraFinLabor(dtp);
        }

        private void dtpHoraInicioBreak_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            if (dtp.CustomFormat != " ")
            {
                ValidarHoraInicioBreak(dtp);
            }
        }

        private void dtpHoraFinBreak_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            if (dtp.CustomFormat != " ")
            {
                ValidarHoraFinBreak(dtp);
            }
        }

        private void dtpTiempoTolerancia_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            ValidarTiempoTolerancia(dtp);
        }

        private void DtpBreak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape && ((DateTimePicker)sender).CustomFormat != " ")
            {
                errorProv.SetError(dtpHoraInicioBreak, null);
                errorProv.SetError(dtpHoraFinBreak, null);

                ControlHelper.FormatDatePicker(dtpHoraInicioBreak, customFormat: " ");
                ControlHelper.FormatDatePicker(dtpHoraFinBreak, customFormat: " ");
            }
        }

        private void DtpBreak_MouseDown(object sender, MouseEventArgs e)
        {
            if (((DateTimePicker)sender).CustomFormat != DateFormat.TimeDefault)
            {
                var tuplaHorasBrkDisponibles = GetHorasBreakDisponible(GetHoraYMinutos(dtpHoraInicioLabor.Value.TimeOfDay), GetHoraYMinutos(dtpHoraFinLabor.Value.TimeOfDay));
                dtpHoraInicioBreak.Value = Convert.ToDateTime(tuplaHorasBrkDisponibles.Item1.ToString());
                dtpHoraFinBreak.Value = Convert.ToDateTime(tuplaHorasBrkDisponibles.Item2.ToString());

                ControlHelper.FormatDatePicker(dtpHoraInicioBreak, customFormat: DateFormat.TimeDefault);
                ControlHelper.FormatDatePicker(dtpHoraFinBreak, customFormat: DateFormat.TimeDefault);
            }
        }

        private Tuple<TimeSpan, TimeSpan> GetHorasBreakDisponible(TimeSpan horaInicio, TimeSpan horaFin)
        {
            var AnchoHoras = horaFin - horaInicio;

            var horaInicioBreakDisponible = horaInicio;
            var horaFinBreakDisponible = horaInicio;
            //Si el ancho de tiempo es mayor a 5 minutos al menos para sugerir los horas brk disponibles
            if (AnchoHoras >= new TimeSpan(0, 5, 0))
            {
                try
                {
                    var mitadDeAncho = new TimeSpan(0, AnchoHoras.Minutes / 2, 0);
                    mitadDeAncho = mitadDeAncho.Add(new TimeSpan(0,
                                            GetMinutosDeHoras(double.Parse(AnchoHoras.Hours.ToString()) / 2),
                                            0));

                    horaInicioBreakDisponible = horaInicioBreakDisponible.Add(mitadDeAncho);

                    if (mitadDeAncho >= new TimeSpan(3, 30, 0))
                    {
                        horaFinBreakDisponible = horaInicioBreakDisponible.Add(new TimeSpan(1, 0, 0));
                    }
                    else if (mitadDeAncho >= new TimeSpan(2, 0, 0))
                    {
                        horaFinBreakDisponible = horaInicioBreakDisponible.Add(new TimeSpan(0, 30, 0));
                    }
                    else if (mitadDeAncho >= new TimeSpan(1, 0, 0))
                    {
                        horaFinBreakDisponible = horaInicioBreakDisponible.Add(new TimeSpan(0, 15, 0));
                    }
                    else
                    {
                        //entra aquí cuando mitad de ancho es menor a 1 hora
                        horaFinBreakDisponible = horaInicioBreakDisponible.Add(new TimeSpan(0, mitadDeAncho.Minutes / 2, 0));
                    }
                }
                catch
                {
                    horaInicioBreakDisponible = horaInicio;
                    horaFinBreakDisponible = horaInicio;
                }
            }

            int GetMinutosDeHoras(double numHoras)
            {
                return int.Parse((numHoras * 60).ToString());
            }

            return new Tuple<TimeSpan, TimeSpan>(horaInicioBreakDisponible, horaFinBreakDisponible);
        }

        private void FormAsignarOEditarDia_Load(object sender, EventArgs e)
        {
            ConfigurarControles();
            SetHorarioDtl();
            AddHandlers();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            if (EsValido())
            {
                var success = false;
                var msgError = "";
                var horarioDtl = GetHorarioDtl();

                if (_TipoOperacion == TipoOperacion.EditarHoratioDtl)
                {
                    if (chkModificarEnTodosLosMismosDias.Checked)
                    {
                        var hoy = UtilBL.GetCurrentDateTime.Date;
                        success = new HorarioEmpleadoBL().ActualizarHorariosDtlXDiaDeSemana(horarioDtl, hoy, horarioDtl.fecha_labor);
                    }
                    else
                    {
                        success = new HorarioEmpleadoBL().ActualizarHorarioDtl(horarioDtl);
                    }
                    msgError = "No se pudo realizar la actualización";
                    SalidaDeOperacion(false);
                }
                else if (_TipoOperacion == TipoOperacion.AsignarHorarioDtl)
                {
                    msgError = "No se pudo asignar la fecha.";
                    success = new HorarioEmpleadoBL().InsertarHorarioDtl(horarioDtl) > 0;
                    SalidaDeOperacion();
                }
                else if (_TipoOperacion == TipoOperacion.CrearHorarioYAsignarHorarioDtl)
                {
                    var horario = new LABt03_horario_emp()
                    {
                        id_empleado = _idEmpleado,
                        fecha_inicio_horario = _fechaAAsignar,
                        fecha_fin_horario = _fechaAAsignar,
                        LABt04_horario_emp_dtl = new List<LABt04_horario_emp_dtl>(),
                    };

                    horario.LABt04_horario_emp_dtl.Add(horarioDtl);

                    success = new HorarioEmpleadoBL().InsertarHorario(horario) > 0;

                    msgError = "No se pudo asignar la fecha.";
                    SalidaDeOperacion(false);
                }

                void SalidaDeOperacion(bool actualizarRango = true)
                {
                    if (success)
                    {
                        _seOpero = true;

                        if (actualizarRango && !(new HorarioEmpleadoBL().ActualizarRangoDeHorario(_idHorario)))
                        {
                            Msg.Ok_Err("No se pudo actualizar la cabecera del horario (primera fecha, útlima fecha).");
                        }
                        Dispose();
                    }
                    else
                    {
                        Msg.Ok_Err(msgError);
                    }
                }
            }
        }

        private bool EsValido()
        {
            bool no_error = true;
            var hoy = UtilBL.GetCurrentDateTime.Date;
            var horaInicioLabor = GetHoraYMinutos(dtpHoraInicioLabor.Value.TimeOfDay);
            var horaFinLabor = GetHoraYMinutos(dtpHoraFinLabor.Value.TimeOfDay);
            var maxTolerancia = (horaFinLabor - horaInicioLabor);
            var tiempoTolerancia = GetHoraYMinutos(dtpTiempoTolerancia.Value.TimeOfDay);

            errorProv.Clear();
            var fechaAValidar = hoy;
            if(_TipoOperacion == TipoOperacion.EditarHoratioDtl)
            {
                fechaAValidar = _horarioDtl.fecha_labor;
            }
            else if(_TipoOperacion == TipoOperacion.AsignarHorarioDtl || _TipoOperacion == TipoOperacion.CrearHorarioYAsignarHorarioDtl)
            {
                fechaAValidar = _fechaAAsignar;
            }

            if (hoy > fechaAValidar)
            {
                no_error = false;
                Msg.Ok_Info("No se puede actualizar una fecha inferior a la fecha actual.", "Validación");
            }

            else if (no_error)
            {
                if (horaInicioLabor > horaFinLabor)
                {
                    no_error = false;
                    errorProv.SetError(dtpHoraInicioLabor, "La \"Hora Inicio\" no puede ser mayor que la \"Hora Fin\".");
                    dtpHoraInicioLabor.Focus();
                }
                else if (tiempoTolerancia > maxTolerancia)
                {
                    no_error = false;
                    errorProv.SetError(dtpTiempoTolerancia, $"El tiempo de \"Tolerancia\" sobrepasa al rango de horas del día ({maxTolerancia.ToString()} horas).");
                    dtpTiempoTolerancia.Focus();
                }

                if (dtpHoraInicioBreak.CustomFormat != " " && dtpHoraInicioBreak.CustomFormat != " ")
                {
                    var horaInicioBrk = GetHoraYMinutos(dtpHoraInicioBreak.Value.TimeOfDay);
                    var horaFinBrk = GetHoraYMinutos(dtpHoraFinBreak.Value.TimeOfDay);

                    if (horaInicioBrk < horaInicioLabor)
                    {
                        no_error = false;
                        errorProv.SetError(dtpHoraInicioBreak, "La hora \"Inicio break\" no puede ser menor que la \"Hora inicio\".");
                        dtpHoraInicioBreak.Focus();
                    }
                    else if (horaInicioBrk > horaFinLabor)
                    {
                        no_error = false;
                        errorProv.SetError(dtpHoraInicioBreak, "La hora \"Inicio break\" no puede ser mayor que la \"Hora fin\".");
                        dtpHoraInicioBreak.Focus();
                    }
                    else if (horaFinBrk < horaInicioLabor)
                    {
                        no_error = false;
                        errorProv.SetError(dtpHoraFinBreak, "La hora \"Fin break\" no puede ser menor que la \"Hora inicio\".");
                        dtpHoraFinBreak.Focus();
                    }
                    else if (horaFinBrk > horaFinLabor)
                    {
                        no_error = false;
                        errorProv.SetError(dtpHoraFinBreak, "La hora \"Fin break\" no puede ser mayor que la \"Hora fin\".");
                        dtpHoraFinBreak.Focus();
                    }
                    else if (horaInicioBrk > horaFinBrk)
                    {
                        no_error = false;
                        errorProv.SetError(dtpHoraInicioBreak, "La hora \"Inicio break\" no puede ser mayor que la hora \"Fin break\".");
                        dtpHoraInicioBreak.Focus();
                    }
                }
            }
            return no_error;
        }

    }
}
