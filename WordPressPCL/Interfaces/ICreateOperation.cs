using System.Threading.Tasks;

namespace WordPressPCL.Interfaces
{
    /// <summary>
    /// Interface with required Create methods
    /// </summary>
    /// <typeparam name="TClass">return class type</typeparam>
    public interface ICreateOperation<TClass>
    {
        /// <summary>
        /// Create object
        /// </summary>
        /// <param name="Entity">object to create</param>
        /// <param name="consumerKey"></param>
        /// <param name="consumerSecret"></param>
        /// <returns>Created object</returns>
        Task<TClass?> CreateAsync(TClass Entity, string? consumerKey = null, string? consumerSecret = null);
    }
}