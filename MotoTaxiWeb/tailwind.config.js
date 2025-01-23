/** @type {import('tailwindcss').Config} */

module.exports = {
  content: [
    "./src/**/*.{html,ts}",
  ],
  theme: {
    extend: {
      colors: {
        'scrollbar-thumb': '#28a745', // Cor verde para o "thumb"
        'scrollbar-track': '#f1f1f1', // Cor para a parte de fundo da barra
      },
      width: {
        'scrollbar': '12px', // Largura da barra de rolagem
      }
    },
  },
  plugins: [
    require('tailwind-scrollbar'), // Adicionando o plugin para scrollbars
  ],
}
