using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tpmodul9_2311104057.Models;

namespace tpmodul9_2311104057.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Reyner", Nim = "2311104057" },
            new Mahasiswa { Nama = "Ilham", Nim = "2311104068" },
            new Mahasiswa { Nama = "Aulia", Nim = "2311104066" }
        };

        // GET: api/Mahasiswa
        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAllMahasiswa()
        {
            return Ok(daftarMahasiswa);
        }

        // GET: api/Mahasiswa/{index}
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetMahasiswaByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            return Ok(daftarMahasiswa[index]);
        }

        // POST: api/Mahasiswa
        [HttpPost]
        public ActionResult<Mahasiswa> CreateMahasiswa([FromBody] Mahasiswa mahasiswa)
        {
            if (mahasiswa == null)
            {
                return BadRequest();
            }
            daftarMahasiswa.Add(mahasiswa);
            return CreatedAtAction(nameof(GetMahasiswaByIndex), new { index = daftarMahasiswa.Count - 1 }, mahasiswa);
        }

        // PUT: api/Mahasiswa/{index}
        [HttpPut("{index}")]
        public ActionResult UpdateMahasiswa(int index, [FromBody] Mahasiswa mahasiswa)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            if (mahasiswa == null)
            {
                return BadRequest();
            }
            daftarMahasiswa[index] = mahasiswa;
            return NoContent();
        }

        // DELETE: api/Mahasiswa/{index}
        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            daftarMahasiswa.RemoveAt(index);
            return NoContent();
        }
    }
}