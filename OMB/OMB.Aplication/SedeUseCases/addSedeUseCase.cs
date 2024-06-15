namespace OMB.Aplication.SedeUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addSedeUseCase {

    public readonly ISedeRepository repository;

    public addSedeUseCase (ISedeRepository repository) {
        this.repository = repository;
    }

    public void Execute (Sede sede) {
        repository.addSede(sede);
    }

}