namespace Base
{
    /// <summary>
    /// Base class that contains methods and attributes commons.
    /// </summary>
    public abstract class BaseAPI
    {
        private readonly string name;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">Value to set Base Name.</param>
        public BaseAPI(string name)
        {
            this.name = name.ToLower();
        }

        /// <summary>
        /// Get name value.
        /// </summary>
        /// <returns>string with name value.</returns>
        public string GetName()
        {
            return name;
        }
    }
}
