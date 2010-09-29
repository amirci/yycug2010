using Rhino.Mocks;
using MavenThought.Commons.Testing;

namespace MavenThought.MediaLibrary.WebClient.Tests.Controllers
{
    /// <summary>
    /// Specification when creating the form to enter a movie
    /// </summary>
    [Specification]
    public class When_movies_controller_creates_a_movie : MoviesControllerSpecification
    {
        /// <summary>
        /// Call the create method to present the form
        /// </summary>
        protected override void WhenIRun()
        {
            this.Sut.Create();
        }
    }
}