using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhosMyPokemon.Models
{
    public interface IExpectedResults
    {
        IEnumerable<IDictionary<ITrainerModel, IPokemonModel>> ExpectedPair { get; set; }
    }
}
