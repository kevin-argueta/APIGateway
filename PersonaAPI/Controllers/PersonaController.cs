using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonaAPI.Models;
using System.Text.RegularExpressions;

[Route("api/[controller]")]
[ApiController]
public class PersonaController : ControllerBase
{
    private readonly PersonasDbContext _context;
    public PersonaController(PersonasDbContext context)
    {
        _context = context;
    }

    // GET: api/Persona
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Persona>>> GetPersona()
    {
        return await _context.Personas.ToListAsync();
    }

    // GET: api/Persona/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Persona>> GetPersona(int id)
    {
        var persona = await _context.Personas.FindAsync(id);

        if (persona == null)
        {
            return NotFound();
        }

        return persona;
    }

    // PUT: api/Persona/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPersona(int? id, Persona persona)
    {
        if (id != persona.Id)
        {
            return BadRequest();
        }
            if (string.IsNullOrWhiteSpace(persona.PrimerNombre))
            {
                return BadRequest("La persona no tiene primer nombre.");
            }

            if (string.IsNullOrWhiteSpace(persona.PrimerApellido))
            {
                return BadRequest("La persona no tiene primer apellido.");
            }

            if (persona.PrimerNombre.Length > 100)
            {
                return BadRequest("El primer nombre no puede exceder los 100 caracteres.");
            }

            if (persona.SegundoNombre != null && persona.SegundoNombre.Length > 100)
            {
                return BadRequest("El segundo nombre no puede exceder los 100 caracteres.");
            }

            if (persona.PrimerApellido.Length > 100)
            {
                return BadRequest("El primer apellido no puede exceder los 100 caracteres.");
            }

            if (persona.SegundoApellido != null && persona.SegundoApellido.Length > 100)
            {
                return BadRequest("El segundo apellido no puede exceder los 100 caracteres.");
            }

            if (persona.FechaNacimiento == default)
            {
                return BadRequest("La persona no tiene fecha de nacimiento válida.");
            }

            if (!Regex.IsMatch(persona.DUI, @"^\d{8}-\d{1}$"))
            {
                return BadRequest("La persona no tiene DUI válido.");    
        }
        _context.Entry(persona).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PersonaExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Persona
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Persona>> PostPersona(Persona persona)
    {
        if (string.IsNullOrWhiteSpace(persona.PrimerNombre))
        {
            return BadRequest("La persona no tiene primer nombre.");
        }

        if (string.IsNullOrWhiteSpace(persona.PrimerApellido))
        {
            return BadRequest("La persona no tiene primer apellido.");
        }

        if (persona.PrimerNombre.Length > 100)
        {
            return BadRequest("El primer nombre no puede exceder los 100 caracteres.");
        }

        if (persona.SegundoNombre != null && persona.SegundoNombre.Length > 100)
        {
            return BadRequest("El segundo nombre no puede exceder los 100 caracteres.");
        }

        if (persona.PrimerApellido.Length > 100)
        {
            return BadRequest("El primer apellido no puede exceder los 100 caracteres.");
        }

        if (persona.SegundoApellido != null && persona.SegundoApellido.Length > 100)
        {
            return BadRequest("El segundo apellido no puede exceder los 100 caracteres.");
        }

        if (persona.FechaNacimiento == default)
        {
            return BadRequest("La persona no tiene fecha de nacimiento válida.");
        }

        if (!Regex.IsMatch(persona.DUI, @"^\d{8}-\d{1}$"))
        {
            return BadRequest("La persona no tiene DUI válido.");
        }
        _context.Personas.Add(persona);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetPersona", new { id = persona.Id }, persona);
    }

    // DELETE: api/Persona/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePersona(int? id)
    {
        var persona = await _context.Personas.FindAsync(id);
        if (persona == null)
        {
            return NotFound();
        }

        _context.Personas.Remove(persona);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool PersonaExists(int? id)
    {
        return _context.Personas.Any(e => e.Id == id);
    }
}
