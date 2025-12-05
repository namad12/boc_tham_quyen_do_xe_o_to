using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SaveJsonController : ControllerBase
{
    /// <summary>
    /// => Lưu dữ liệu danh sách các căn hộ bốc thăm 
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    [HttpPost("danh-sach-can-ho")]
    public IActionResult SaveDanhSachCanHo([FromBody] object json)
    {
        try
        {
            string savePath = Path.Combine(Directory.GetCurrentDirectory(), @"C:\BocThamQuyenDoXe\InputData", "danh_sach_boc_tham_quyen_do_o_to.json");
            System.IO.File.WriteAllText(savePath, json.ToString());
            return Ok(new { message = "Saved danh_sach_boc_tham_quyen_do_o_to.json" });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    /// <summary>
    /// => Lưu danh sách quyền bốc thăm đỗ xe ô tô
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    [HttpPost("quyen-do-o-to")]
    public IActionResult SaveQuyenDoOTo([FromBody] object json)
    {
        try
        {
            string savePath = Path.Combine(Directory.GetCurrentDirectory(), @"C:\BocThamQuyenDoXe\InputData", "danh_sach_quyen_do_o_to.json");
            System.IO.File.WriteAllText(savePath, json.ToString());
            return Ok(new { message = "Saved danh_sach_quyen_do_o_to.json" });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
