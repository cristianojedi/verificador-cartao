﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace verificador_cartao {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Mensagens {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Mensagens() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("verificador_cartao.Mensagens", typeof(Mensagens).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a inválido.
        /// </summary>
        internal static string CartaoInvalido {
            get {
                return ResourceManager.GetString("CartaoInvalido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a válido.
        /// </summary>
        internal static string CartaoValido {
            get {
                return ResourceManager.GetString("CartaoValido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a DIGITE APENAS NÚMEROS.
        /// </summary>
        internal static string DigiteApenasNumeros {
            get {
                return ResourceManager.GetString("DigiteApenasNumeros", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a DIGITE O NÚMERO DO CARTÃO.
        /// </summary>
        internal static string DigiteNumeroCartao {
            get {
                return ResourceManager.GetString("DigiteNumeroCartao", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a O NÚMERO DEVE CONTER NO MÁXIMO 16 CARACTERES.
        /// </summary>
        internal static string DigiteNumeroMaximoCaracteres {
            get {
                return ResourceManager.GetString("DigiteNumeroMaximoCaracteres", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a AMEX.
        /// </summary>
        internal static string TipoCartaoAmex {
            get {
                return ResourceManager.GetString("TipoCartaoAmex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a DESCONHECIDO.
        /// </summary>
        internal static string TipoCartaoDesconhecido {
            get {
                return ResourceManager.GetString("TipoCartaoDesconhecido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a DISCOVER.
        /// </summary>
        internal static string TipoCartaoDiscover {
            get {
                return ResourceManager.GetString("TipoCartaoDiscover", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a MASTERCARD.
        /// </summary>
        internal static string TipoCartaoMastercard {
            get {
                return ResourceManager.GetString("TipoCartaoMastercard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a VISA.
        /// </summary>
        internal static string TipoCartaoVisa {
            get {
                return ResourceManager.GetString("TipoCartaoVisa", resourceCulture);
            }
        }
    }
}
