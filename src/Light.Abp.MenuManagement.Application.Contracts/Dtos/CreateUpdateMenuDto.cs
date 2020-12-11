using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Light.Abp.MenuManagement.Dtos
{
    public class CreateUpdateMenuDto
    {
        public CreateUpdateMenuDto()
        {
        }
        [Required]
        [MaxLength(255)]
        public string MenuName { get; set; }

        [Required]
        [MaxLength(255)]
        public string DisplayName { get; set; }

        [Required]
        [MaxLength(255)]
        public string Url { get; set; }

        /// <summary>
        /// ������Ȩ������
        /// </summary>
        /// <value>The name of the permission.</value>
        [MaxLength(255)]
        public string PermissionName { get; set; }

        [Required]
        [MaxLength(255)]
        public string Icon { get; set; }

        public bool IsDisabled { get; set; }

        public int Order { get; set; }

        public Guid? ParentId { get; set; }

        public Guid? TenantId { get; set; }
    }
}