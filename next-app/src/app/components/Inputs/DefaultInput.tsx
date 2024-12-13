type DefaultInputProps = {
  value: string;
  label: string;
  placeholder?: string;
  type?: "text" | "select";
  inputType?: string;
  options?: { value: number; option: string }[];
  max?: number;
  onChange: (
    e:
      | React.ChangeEvent<HTMLInputElement>
      | React.ChangeEvent<HTMLSelectElement>
  ) => void;
};

const DefaultInput = ({
  value,
  label,
  options,
  placeholder,
  type = "text",
  inputType,
  onChange,
  max,
}: DefaultInputProps) => {
  return (
    <div>
      <label className="block font-medium">{label}</label>
      {type === "select" ? (
        <select
          className="invalid:text-gray-400 w-full pl-3 py-2 border border-borders rounded-md focus:outline-none focus:border-[#bfbbc5]"
          required
          value={value}
          onChange={onChange}
        >
          <option disabled hidden value="">
            Selecione uma opção...
          </option>
          {options &&
            options.map((option) => (
              <option
                className="text-black"
                key={option.value}
                value={option.value}
              >
                {option.option}
              </option>
            ))}
        </select>
      ) : (
        <input
          className="w-full pl-3 py-2 border border-borders rounded-md focus:outline-none focus:border-[#bfbbc5]"
          type={inputType}
          placeholder={placeholder}
          value={value}
          onChange={onChange}
          maxLength={max}
          minLength={max}
          required
        />
      )}
    </div>
  );
};

export default DefaultInput;
