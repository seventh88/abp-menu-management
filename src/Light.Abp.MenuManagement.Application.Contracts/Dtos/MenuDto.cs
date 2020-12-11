using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Light.Abp.MenuManagement.Dtos
{
    public class MenuDto : AuditedEntityDto<Guid>
    {
        public virtual string MenuName { get; set; }

        public virtual string DisplayName { get; set; }

        public virtual string Url { get; set; }

        /// <summary>
        /// ������Ȩ������
        /// </summary>
        /// <value>The name of the permission.</value>
        public virtual string PermissionName { get; set; }

        public virtual string Icon { get; set; }

        public virtual bool IsDisabled { get; set; }

        public virtual int Order { get; set; }

        public virtual Guid? ParentId { get; set; }

        public Dictionary<string, object> ExtraProperties { get; set; }

        public virtual Guid? TenantId { get; set; }
        
    }
}