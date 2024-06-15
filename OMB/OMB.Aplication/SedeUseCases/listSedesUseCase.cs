namespace OMB.Aplication.SedeUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class listSedesUseCase {

    public readonly ISedeRepository repository;

    public listSedesUseCase (ISedeRepository repository) {
        this.repository = repository;
    }

    public List<Sede> Execute () {
        return repository.sedeList();
    }

}