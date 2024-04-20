﻿using CapaModelo;
using Microsoft.EntityFrameworkCore;
using FP._059_NAGASystems_Prod2.Data;

public class HabitacionServicio
{
    private readonly FP_059_NAGASystems_Prod2Context _context;

    public HabitacionServicio(FP_059_NAGASystems_Prod2Context context)
    {
        _context = context;
    }

    public async Task<List<Habitacion>> ObtenerHabitacionesDisponibles(DateTime fechaInicio, DateTime fechaFin)
    {
        var habitacionesOcupadas = await _context.Reserva
            .Where(r => r.FechaInicio < fechaFin && r.FechaFin > fechaInicio && r.Cancelado == 0)
            .Select(r => r.Habitacion)
            .Distinct()
            .ToListAsync();

        var habitacionesDisponibles = await _context.Habitacion
            .Where(h => !habitacionesOcupadas.Contains(h.Numero))
            .ToListAsync();

        return habitacionesDisponibles;
    }
}