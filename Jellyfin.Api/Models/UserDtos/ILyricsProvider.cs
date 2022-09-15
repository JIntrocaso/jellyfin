using System.Collections.ObjectModel;
using MediaBrowser.Controller.Entities;

namespace Jellyfin.Api.Models.UserDtos
{
    /// <summary>
    /// Interface ILyricsProvider.
    /// </summary>
    public interface ILyricsProvider
    {
        /// <summary>
        /// Gets a value indicating the File Extenstions this provider works with.
        /// </summary>
        public Collection<string>? FileExtensions { get; }

        /// <summary>
        /// Gets a value indicating whether Process() generated data.
        /// </summary>
        /// <returns><c>true</c> if data generated; otherwise, <c>false</c>.</returns>
        bool HasData { get; }

        /// <summary>
        /// Gets Data object generated by Process() method.
        /// </summary>
        /// <returns><c>Object</c> with data if no error occured; otherwise, <c>null</c>.</returns>
        object? Data { get; }

        /// <summary>
        /// Opens lyric file for [the specified item], and processes it for API return.
        /// </summary>
        /// <param name="item">The item to to process.</param>
        void Process(BaseItem item);
    }
}