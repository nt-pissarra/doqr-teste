const tableTitles = [
  "Nome",
  "E-mail",
  "CPF",
  "Celular",
  "Data de Nascimento",
  "Tipo de Contratação",
  "Status",
  "Ação",
];

const titles = tableTitles.map((title: string, i) => (
  <span className="table-header__title" key={i}>
    {title}
  </span>
));

const TableHeader = () => {
  return (
    <header className="table-header grid grid-cols-[130px_260px_minmax(120px,_180px)_minmax(120px,_280px)_minmax(120px,_260px)_minmax(120px,_210px)_120px_70px]">
      {titles}
    </header>
  );
};

export default TableHeader;
