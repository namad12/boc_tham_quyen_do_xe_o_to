using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class LoadJsonController : ControllerBase
{
    /// <summary>
    /// => Load dữ liệu danh sách các căn hộ bốc thăm 
    /// </summary>
    /// <returns></returns>
    [HttpGet("danh-sach-can-ho")]
    public IActionResult LoadDanhSachCanHo()
    {
        string filePath = @"C:\BocThamQuyenDoXe\InputData\danh_sach_boc_tham_quyen_do_o_to.json";

        if (!System.IO.File.Exists(filePath))
            return NotFound("File not found!");

        var json = System.IO.File.ReadAllText(filePath);
        return Ok(json);
    }

    /// <summary>
    /// => Load danh sách quyền bốc thăm đỗ xe ô tô
    /// </summary>
    /// <returns></returns>
    [HttpGet("quyen-do-o-to")]
    public IActionResult LoadQuyenDoOTo()
    {
        string filePath = @"C:\BocThamQuyenDoXe\InputData\danh_sach_quyen_do_o_to.json";

        if (!System.IO.File.Exists(filePath))
            return NotFound("File not found!");

        var json = System.IO.File.ReadAllText(filePath);
        return Ok(json);
    }
}
