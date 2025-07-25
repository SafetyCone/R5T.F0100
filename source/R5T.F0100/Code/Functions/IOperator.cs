using System;

using R5T.T0132;


namespace R5T.F0100
{
    [FunctionalityMarker]
    public partial interface IOperator
    {
        public string Get_TagContent(
            string tagName,
            string attributeContent)
        {
            var attributeContent_IsNullOrEmpty = Instances.StringOperator.Is_NullOrEmpty(attributeContent);

            var output = attributeContent_IsNullOrEmpty
                ? tagName
                : Instances.StringOperator.Concatenate(
                    tagName,
                    Instances.Strings.Space,
                    attributeContent
                )
                ;

            return output;
        }
    }
}
