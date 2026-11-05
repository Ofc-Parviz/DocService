using Sm.Ui.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace DocService.Data {

    /// <summary>
    /// مدل داده ای هر سند راهنما
    /// </summary>
    public class DocumentModel {

        /// <summary>
        /// شناسه عددی - اضافه شونده خودکار
        /// </summary>
        [Key]
        [Required]
        public long Id { get; set; }

        /// <summary>
        /// عنوان سند
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        /// <summary>
        /// تاریخ ایجاد
        /// </summary>
        [Required]
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// آخرین ویرایش
        /// </summary>
        [Required]
        public DateTime UpdatedAtUtc { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// اطلاعات جیسون شده بخش ها - بدون محدودیت تعداد کاراکتر
        /// </summary>
        [Required]
        public string SectionsJson { get; set; }

        public Document_Entry AsEntry
            (bool needUpdate = false,
             bool increaseWindowSize = false)

            => new Document_Entry() {
                Title = Title,
                Last_Updated_Date = UpdatedAtUtc.Get_Shamsi_Short_Date(),
                Last_Updated_Clock = UpdatedAtUtc.Get_Shamsi_Short_Time(),
                Increase_Window_Size = increaseWindowSize,
                Need_Update = needUpdate,
                Sections = SectionsJson.Json_To_Ui<Document_Entry.Section[]>()
            };
    }
}
