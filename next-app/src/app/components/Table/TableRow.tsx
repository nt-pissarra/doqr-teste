"use client";

import { editIcon, deleteIcon } from "@/assets/icons";
import { User } from "@/types/userType";
import Image from "next/image";
import { useRouter } from "next/navigation";

type TableRowProps = {
  data: User;
  deleteUser: (id: number) => void;
};

const mapEmploymentType = (employmentType: number): string => {
  switch (employmentType) {
    case 1:
      return "CLT";
    case 2:
      return "PJ";
    default:
      return "Unknown";
  }
};

const TableRow = ({ data, deleteUser }: TableRowProps) => {
  const router = useRouter();

  const editUser = (id: number) => {
    router.push(`edit/${id}`);
  };

  return (
    <div className="table-row grid-cols-[130px_260px_minmax(120px,_180px)_minmax(120px,_280px)_minmax(120px,_260px)_minmax(120px,_210px)_120px_70px]">
      <span className="font-bold break-words">{data.name}</span>
      <span className="overflow-hidden break-words">{data.email}</span>
      <span>{data.cpf}</span>
      <span>{data.phone}</span>
      <span>{new Date(data.birthDate).toLocaleDateString("pt-BR")}</span>
      <span>{mapEmploymentType(data.employmentType)}</span>
      <div>
        <span
          className={`h-[25px] py-1 px-[8px] rounded-[12.5px] font-medium inline-flex items-center justify-center ${
            data.status === 1
              ? "text-[#034906] bg-[#B5F8B7]"
              : "text-[#300404] bg-[#FBC9C9]"
          } font-bold`}
        >
          {data.status === 1 ? "Ativo" : "Inativo"}
        </span>
      </div>
      <span className="flex items-center gap-3 last:col-span-1">
        <button onClick={() => editUser(data.id)}>
          <Image width={18} height={18} src={editIcon.src} alt="edit-icon" />
        </button>
        <button onClick={() => deleteUser(data.id)}>
          <Image
            width={16}
            height={18}
            src={deleteIcon.src}
            alt="delete-icon"
          />
        </button>
      </span>
    </div>
  );
};

export default TableRow;
