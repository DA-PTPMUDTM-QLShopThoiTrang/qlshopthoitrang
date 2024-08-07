const user = (function () {
  const modal = document.querySelector("#modal-ai");
  const btnOpen = document.querySelector("#btn-open-ai");
  const btnClose = document.querySelector("#btn-close-ai");
  const form = document.querySelector("#form-ai");
  const ipAge = form.elements["ai_age"];
  const ipHeight = form.elements["ai_height"];
  const ipWeight = form.elements["ai_weight"];
  const err = document.querySelector(".errmodal-ai");
  const elmLoading = document.getElementById("modal-ai__loading");
  const elmContent = document.getElementById("modal-ai__content");
  const elmIMG = document.getElementById("modal-ai__img");
  let idTimeOut = null;
  return {
    addErr(elm, mes) {
      elm.classList.add("border-red-500");
      elm.nextElementSibling.innerHTML = mes;
      elm.nextElementSibling.classList.remove("hidden");
    },
    removeErr(elm) {
      elm.classList.remove("border-red-500");
      elm.classList.add("border-gray-200");
      elm.nextElementSibling.classList.add("hidden");
    },
    removeAllErr() {
      this.removeErr(ipAge);
      this.removeErr(ipHeight);
      this.removeErr(ipWeight);
      err.classList.add("hidden");
    },
    async fetchDataPost(age, height, weight) {
      const res = await fetch("https://localhost:44379/predict", {
        method: "POST",
        headers: {
          "Content-Type": "application/json; charset=utf-8",
        },
        body: JSON.stringify({
          Age: age,
          Height: height,
          Weight: weight,
        }),
      });
      const data = await res.json();
      return data;
    },

    showList(data) {
      elmContent.innerHTML = "";
      const labels = ["S", "L", "M"];
      data.forEach((item, index) => {
        const div = document.createElement("div");
        div.innerHTML += `
            <div class="flex items-center justify-between mb-2 w-[${(
              item * 100
            ).toFixed(3)}%]">
                <span>${labels[index]}</span>
                <div class="inline-block py-0.5 px-1.5 bg-blue-50 border border-blue-200 text-xs font-medium text-blue-600 rounded-lg">
                ${(item * 100).toFixed(3)}%
                </div>
            </div>
            <div class="progress-bar flex w-full h-2.5 bg-gray-200 rounded-full overflow-hidden" role="progressbar" aria-valuenow="${(
              item * 100
            ).toFixed(3)}" aria-valuemin="0" aria-valuemax="100">
                <div class=" flex flex-col justify-center rounded-full overflow-hidden bg-gradient-to-r from-pink-500 to-violet-600 text-xs text-white text-center whitespace-nowrap transition duration-500" style="width: ${(
                  item * 100
                ).toFixed(3)}%"></div>
            </div>
          `;
        elmContent.appendChild(div);
      });
    },
    async init() {
      // open modal
      btnOpen.addEventListener("click", () => {
        this.removeAllErr();
        form.reset();
        modal.classList.remove("hidden");
        modal.classList.add("fixed");
      });

      // close modal
      btnClose.addEventListener("click", () => {
        elmContent.innerHTML = "";
        elmContent.classList.add("hidden");
        elmLoading.classList.add("hidden");
        elmIMG.classList.remove("hidden");
        modal.classList.remove("fixed");
        modal.classList.add("hidden");
      });

      form.addEventListener("submit", async (e) => {
        e.preventDefault();
        let isValid = true;
        if (
          !/^[0-9]{1,}$/.test(ipAge.value) ||
          parseFloat(ipWeight.value) < 0
        ) {
          isValid = false;
          this.addErr(ipAge, "Tuổi không hợp lệ!");
        }
        if (
          !/^[0-9.]{1,}$/.test(ipWeight.value) ||
          parseFloat(ipWeight.value) < 0
        ) {
          isValid = false;
          this.addErr(ipWeight, "Cân nặng không hợp lệ!");
        }
        if (
          !/^[0-9.]{1,}$/.test(ipHeight.value) ||
          parseFloat(ipHeight.value) < 0
        ) {
          isValid = false;
          this.addErr(ipHeight, "Chiều cao không hợp lệ!");
        }
        if (isValid) {
          elmContent.classList.add("hidden");
          elmIMG.classList.add("hidden");
          elmLoading.classList.remove("hidden");
          const res = await this.fetchDataPost(
            parseFloat(ipAge.value),
            parseFloat(ipHeight.value),
            parseFloat(ipWeight.value)
          )
            .then((res) => {
              console.log(res);
              this.showList(res["score"]);
            })
            .catch((err) => {
              this.addErr(err, "Đã có lỗi xảy ra. Vui lòng thực hiện lại!");
            })
            .finally((res) => {
              new Promise((resolve, reject) => {
                if (idTimeOut) clearTimeout(idTimeOut);
                idTimeOut = setTimeout(() => {
                  elmLoading.classList.add("hidden");
                  elmContent.classList.remove("hidden");
                }, 1000);
              });
            });
        }
      });

      ipAge.addEventListener("input", () => {
        this.removeErr(ipAge);
      });
      ipHeight.addEventListener("input", () => {
        this.removeErr(ipHeight);
      });
      ipWeight.addEventListener("input", () => {
        this.removeErr(ipWeight);
      });
    },
  };
})();

user.init();
