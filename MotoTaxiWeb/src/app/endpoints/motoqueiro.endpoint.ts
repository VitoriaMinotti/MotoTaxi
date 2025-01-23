
export namespace MotoqueiroEndpoints {

    const base = `api/Motoqueiros`
  
    export const endpoints = {
      getAll: (apiUrl: string) => `${apiUrl}/${base}`,
      create: (apiUrl: string) => `${apiUrl}/${base}`,
    }
  }
  