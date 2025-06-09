/**
 * @author Antonio, Kenette John
 * @createdAt June 9, 2025
 */

using System.ComponentModel;

namespace Group1Lurnyx.Entities.Enums
{
    public class ApplicationPageEnumWrapper
    {
        ApplicationPageEnum pageEnum;

        public ApplicationPageEnumWrapper(ApplicationPageEnum pageEnum)
        {
            this.pageEnum = pageEnum;
        }

        public ApplicationPageEnum PageEnum { get => pageEnum; set => pageEnum = value; }

        public override string ToString()
        {
            DescriptionAttribute attribute = PageEnum.GetType()
            .GetField(PageEnum.ToString())
            .GetCustomAttributes(typeof(DescriptionAttribute), false)
            .SingleOrDefault() as DescriptionAttribute;

            return attribute.Description;
        }


    }
}
