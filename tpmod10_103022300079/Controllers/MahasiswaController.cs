using Microsoft.AspNetCore.Mvc;
using tpmod10_103022300079;
using System.Collections.Generic;
using tpmod10_103022300079;

namespace tpmodul10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Syahdan Mansiz Kurniawan", Nim = "103022300079" },
            new Mahasiswa { Nama = "Muhammad Endihan Alfatah Nasution", Nim = "103022300064" },
            new Mahasiswa { Nama = "Triana Julianingsih", Nim = " 103022300053" },
            new Mahasiswa { Nama = "Mohammad Ilham Firdaus", Nim = "103022300043" },
            new Mahasiswa { Nama = "Muthi'ah Azzahra", Nim = "103022330117" },
            new Mahasiswa { Nama = "Muhammad Ihsan Romdhon", Nim = "103022330150" }

        };

        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetMahasiswa()
        {
            return daftarMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetMahasiswaByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Mahasiswa tidak ditemukan.");
            return daftarMahasiswa[index];
        }

        [HttpPost]
        public ActionResult AddMahasiswa(Mahasiswa mahasiswa)
        {
            daftarMahasiswa.Add(mahasiswa);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Mahasiswa tidak ditemukan.");
            daftarMahasiswa.RemoveAt(index);
            return Ok();
        }
    }
}
