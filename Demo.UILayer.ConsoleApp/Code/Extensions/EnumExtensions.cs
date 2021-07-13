using System;
using System.ComponentModel;

namespace Demo.UILayer.ConsoleApp.Code.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Get a <see cref="Enum" /> value from the specified description value.
        /// </summary>
        /// <typeparam name="TEnum">An enumerated type.</typeparam>
        /// <param name="description">The source value.</param>
        public static TEnum GetValueFromDescription<TEnum>(this string description)
            where TEnum : Enum
        {
            var type = typeof(TEnum);

            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) as DescriptionAttribute;

                if (attribute != null)
                {
                    if (attribute.Description == description)
                    {
                        return (TEnum)field.GetValue(null);
                    }
                }
                else
                {
                    if (field.Name == description)
                    {
                        return (TEnum)field.GetValue(null);
                    }
                }
            }

            throw new ArgumentException(description, nameof(description));
        }
    }
}
