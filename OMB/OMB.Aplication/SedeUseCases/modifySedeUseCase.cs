namespace OMB.Aplication.SedeUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifySedeUseCase {

    public readonly ISedeRepository repository;

    public modifySedeUseCase (ISedeRepository repository) {
        this.repository = repository;
    }

    public void Execute (Sede sede) {
        repository.modifySede(sede);
    }

}