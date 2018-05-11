using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.CommLib
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  帮助类，用于基于DataAnnotations进行基础验证实体类
    // ******************************************************************
    /// <summary>
    /// 帮助类，用于基于DataAnnotations进行基础验证实体类
    /// </summary>
    public static class DataAnnotationHelper
    {
        /// <summary>
        /// 基础验证实体类
        /// </summary>
        public static IEnumerable<ModelValidationError> IsValid<T>(this T o)
        {
            var descriptor = GetTypeDescriptor(typeof(T));

            foreach (PropertyDescriptor propertyDescriptor in descriptor.GetProperties())
            {
                foreach (var validationAttribute in propertyDescriptor.Attributes.OfType<ValidationAttribute>())
                {
                    //原来的
                    //if (!validationAttribute.IsValid(propertyDescriptor.GetValue(o)))
                    //{
                    //    yield return new ModelValidationError() { FieldName = propertyDescriptor.DisplayName, Message = validationAttribute.FormatErrorMessage(propertyDescriptor.Name) };
                    //}
                    //新修改的
                    

                    if (!validationAttribute.IsValid(propertyDescriptor.GetValue(o)))
                    {
                        yield return new ModelValidationError() { FieldName = propertyDescriptor.DisplayName, Message = validationAttribute.FormatErrorMessage(propertyDescriptor.Name) };
                    }
                }
            }
        }

        /// <summary>
        /// 得到需验证的属性信息
        /// </summary>
        private static ICustomTypeDescriptor GetTypeDescriptor(Type type)
        {
            return new AssociatedMetadataTypeTypeDescriptionProvider(type).GetTypeDescriptor(type);
        }
    }
}
