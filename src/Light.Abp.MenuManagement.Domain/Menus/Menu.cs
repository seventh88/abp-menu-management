using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Light.Abp.MenuManagement
{
    public class AbpMenu : AuditedEntity<Guid>, IMultiTenant, IHasExtraProperties
    {
        public AbpMenu()
        {
            ExtraProperties = new ExtraPropertyDictionary();
        }

        public AbpMenu(Guid id, string name, string displayName, string url, string icon, int order, string permissionName, Guid? parentId = null, bool isDisabled = false, Guid? tenantId = null)
        {
            Id = id;
            ParentId = parentId;
            MenuName = name;
            PermissionName = permissionName;
            DisplayName = displayName;
            Url = url;
            Icon = icon;
            Order = order;
            IsDisabled = isDisabled;
            TenantId = tenantId;
            ExtraProperties = new ExtraPropertyDictionary();
        }

        [Required]
        [MaxLength(255)]
        public virtual string MenuName { get; set; }

        [Required]
        [MaxLength(255)]
        public virtual string DisplayName { get; set; }

        [Required]
        [MaxLength(255)]
        public virtual string Url { get; set; }

        /// <summary>
        /// 关联的权限名称
        /// </summary>
        /// <value>The name of the permission.</value>
        [MaxLength(255)]
        public virtual string PermissionName { get; set; }

        [Required]
        [MaxLength(255)]
        public virtual string Icon { get; set; }

        public virtual bool IsDisabled { get; set; }

        public virtual int Order { get; set; }

        public virtual Guid? ParentId { get; set; }

        public ExtraPropertyDictionary ExtraProperties { get; }

        public virtual Guid? TenantId { get; set; }

    }
}
