# Bốc thăm vị trí đỗ xe ô tô 
<img width="1862" height="835" alt="image" src="https://github.com/user-attachments/assets/3584d0b9-56c2-445e-bfa4-482cd819762a" />



### Dữ liệu mẫu Danh sách căn hộ bốc thăm quyền đỗ xe ô tô
```json
[
{
    "id": 1,                          
    "apartCode": "1615",             
    "slot": "Không được quyền đỗ",    
    "selected": 63,                   
    "date": "06-12-2025 06:38:15"   
  },
  {
    "id": 5,
    "apartCode": "12A04",
    "slot": "",
    "selected": 0,
    "date": ""
  }
]
```
#### Giải thích
- Trường `id` => là trường Thứ tự bốc của căn hộ (**id phải đánh thứ tự tăng dần 1 đơn vị từ 1 đến hết, không được đánh id <=0, hay id ko được sắp xếp tăng dần**)
- Trường `apartCode` => là trường Tên căn hộ (**tên các căn hộ không được trùng nhau, nếu trùng thì code sẽ bị lỗi**)
- Trường `slot` => là trường Quyền đỗ xe (nếu slot = "" thì có nghĩa là căn hộ là chưa bốc quyền) (có 4 quyền: **Quyền đỗ hầm, Quyền đỗ sân, Quyền đỗ quanh nhà, Không được quyền đỗ**)
- Trường `selected` => là trường Vị trí ô đã bốc (nếu selected = 0 thì là căn hộ này chưa bốc, **không được để selected < 0** )
- Trường `date` => là trường Ghi lại log ngày giờ căn hộ đã bốc (nếu date = "" thì là căn hộ này chưa bốc)

### Dữ liệu mẫu Danh sách quyền đỗ xe ô tô
```json
{
  "quyenDoHam": 27,
  "quyenDoSan": 15,
  "quyenDoQuanhNha": 34,
  "khongDuocQuyenDo": 46
}
```
#### Giải thích
- Trường `quyenDoHam` => là trường lưu Tổng số phiếu **Quyền đỗ hầm** (trường này không được để <=0)
- Trường `quyenDoSan` => là trường lưu Tổng số phiếu **Quyền đỗ sân** (trường này không được để <=0)
- Trường `quyenDoQuanhNha` => là trường lưu Tổng số phiếu **Quyền đỗ quanh nhà** (trường này không được để <=0)
- Trường `khongDuocQuyenDo` => là trường lưu Tổng số phiếu **Không được quyền đỗ** (trường này không được để <=0)

> Lưu ý: Tổng số phiếu của 4 quyền cộng lại phải bằng tổng căn hộ, nếu không thì code sẽ lỗi

